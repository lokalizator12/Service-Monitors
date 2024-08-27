using ServiceMonitorEVK.Main;
using ServiceMonitorEVK.Source.Util_Managers;
using System;
using System.Configuration;
using System.Windows.Forms;
namespace ServiceMonitorEVK.Source.Main
{
    internal static class Program
    {
        /// <summary>
        ///     Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            ConfigurationSection section = config.GetSection("appSettings");

            if (section != null && !section.SectionInformation.IsProtected)
            {
                // Шифруем секцию
                section.SectionInformation.ProtectSection("RsaProtectedConfigurationProvider");
                section.SectionInformation.ForceSave = true;
                config.Save(ConfigurationSaveMode.Full);
                Console.WriteLine(" appSettings encrypted.");
            }
            var initialsForm = new InitialsForm();
            var timer = new AppManager().StartClosingTimer();

            if (initialsForm.ShowDialog() == DialogResult.OK)
            {

                using (var logManager = new SecureLogManager(ConfigurationManager.AppSettings["EncryptionKey"]))
                {
                    string userInitials = initialsForm.Initials;
                    logManager.Log(userInitials, "Logged into the application");
                    logManager.ClearOldLogs();
                    Form1 mainForm = new Form1(initialsForm.Initials);
                    mainForm.labelAppCloseIn.Text = timer.ToString();
                    AppManager.FadeInForm(mainForm);
                    Application.Run(mainForm);
                }
            }

        }
    }
}