namespace ServiceMonitorEVK.Properties
{
    public static class UserSettingsManager
    {
        public static string GetPreferredLanguage()
        {
            return Settings.Default.Language;
        }

        public static void SetPreferredLanguage(string languageCode)
        {
            Settings.Default.Language = languageCode;
            Settings.Default.Save();
        }
    }
}