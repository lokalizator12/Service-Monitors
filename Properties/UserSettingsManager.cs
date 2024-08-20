namespace ServiceMonitorEVK.Properties
{
    public static class UserSettingsManager
    {
        public static string GetPreferredLanguage()
        {
            return ServiceMonitorEVK.Properties.Settings.Default.Language;
        }

        public static void SetPreferredLanguage(string languageCode)
        {
            ServiceMonitorEVK.Properties.Settings.Default.Language = languageCode;
            ServiceMonitorEVK.Properties.Settings.Default.Save();
        }
    }
}
