using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ServiceMonitorEVK.Source.Util_Managers
{
    public class SecureLogManager : IDisposable
    {
        private readonly string logDirectory = "Logs";
        private readonly string logFileName = $"{DateTime.Now:yyyy-MM-dd}.log";
        private readonly string logFilePath;
        private readonly byte[] encryptionKey;
        private bool disposed;

        public SecureLogManager(string encryptionKey)
        {
            this.encryptionKey = Encoding.UTF8.GetBytes(encryptionKey.PadRight(32).Substring(0, 32));

            logFilePath = Path.Combine(logDirectory, logFileName);
            EnsureDirectoryExists();
        }

        private void EnsureDirectoryExists()
        {
            if (!Directory.Exists(logDirectory))
            {
                Directory.CreateDirectory(logDirectory);
            }
        }

        public void Log(string initials, string action)
        {
            string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {initials}: {action}";
            string encryptedLogEntry = Encrypt(logEntry);
            File.AppendAllText(logFilePath, encryptedLogEntry + Environment.NewLine);
        }

        public void ClearOldLogs(int monthsToKeep = 1)
        {
            var files = Directory.GetFiles(logDirectory);
            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                if (fileInfo.CreationTime < DateTime.Now.AddMonths(-monthsToKeep))
                {
                    fileInfo.Delete();
                }
            }
        }

        private string Encrypt(string plainText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = encryptionKey;
                aesAlg.IV = new byte[16]; // Use a zero IV for simplicity; consider generating a random IV for better security
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Dispose managed resources here
                }

                // Free unmanaged resources here
                disposed = true;
            }
        }
    }
}
