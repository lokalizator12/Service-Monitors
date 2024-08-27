using OpenAI_API;
using OpenAI_API.Chat;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ConfigurationManager = System.Configuration.ConfigurationManager;

namespace ServiceMonitorEVK.Source.Services
{
    public class OpenAIService
    {
        private readonly OpenAIAPI _api;

        public OpenAIService()
        {

            string encryptedApiKey = ConfigurationManager.AppSettings["OpenAI:ApiKey"];
            string encryptionIv = ConfigurationManager.AppSettings["Encryption:IV"];
            string encryptionKey = ConfigurationManager.AppSettings["Encryption:Key"];
            Console.WriteLine($"API Key: {encryptedApiKey}");
            Console.WriteLine($"Encryption IV: {encryptionIv}");
            Console.WriteLine($"Encryption Key: {encryptionKey}");
            if (string.IsNullOrEmpty(encryptedApiKey) || string.IsNullOrEmpty(encryptionIv) || string.IsNullOrEmpty(encryptionKey))
            {
                throw new InvalidOperationException("API key or encryption parameters are missing.");
            }
            string apiKey = DecryptApiKey(encryptedApiKey, encryptionKey, encryptionIv);
            Console.WriteLine($"Encryption apiKey: {apiKey}");
            APIAuthentication aPIAuthentication = new APIAuthentication(apiKey);
            _api = new OpenAIAPI(aPIAuthentication);
        }





        string DecryptApiKey(string cipherText, string key, string iv)
        {
            using (var aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = Encoding.UTF8.GetBytes(iv);
                aesAlg.Mode = CipherMode.CBC;
                aesAlg.Padding = PaddingMode.PKCS7;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (var msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText)))
                {
                    using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (var srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }




        public async Task<string> GetResponseAsync(string prompt, bool isInfoMonitors)
        {
            ChatRequest chatRequest;

            if (isInfoMonitors)
            {
                // When the switch is on, the query is specifically for monitor information
                chatRequest = new ChatRequest
                {
                    Model = "gpt-4o-mini",
                    Messages = new[]
                    {
                        new ChatMessage(ChatMessageRole.System, "You are an assistant that provides monitor specifications in a concise format. For each query, return only the panel type, screen size in inches, and video input ports, separated by commas. No additional text. Format: 'PanelType, ScreenSize, InputPorts'. Example: 'IPS, 23, VGA x1, HDMI x2'."),
                        new ChatMessage(ChatMessageRole.User, prompt)
                    },
                    MaxTokens = 20, // Limit the response length
                    Temperature = 0.3, // Make responses deterministic
                    NumChoicesPerMessage = 1
                };
            }
            else
            {
                // When the switch is off, handle general queries
                chatRequest = new ChatRequest
                {
                    Model = "gpt-4o-mini",
                    Messages = new[]
                    {
                        new ChatMessage(ChatMessageRole.System, "You are a helpful assistant."),
                        new ChatMessage(ChatMessageRole.User, prompt)
                    },
                    MaxTokens = 100, // Allow for longer responses
                    Temperature = 0.7, // Allow for some creativity in responses
                    NumChoicesPerMessage = 1
                };
            }

            var result = await _api.Chat.CreateChatCompletionAsync(chatRequest);

            return result.Choices[0].Message.Content.Trim();
        }

    }
}