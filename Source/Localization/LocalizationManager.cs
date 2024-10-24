using System.Globalization;
using System.Resources;
using System.Threading;

namespace ServiceMonitorEVK.Localization
{
    public sealed class LocalizationManager
    {
        private CultureInfo currentCulture;
        private readonly ResourceManager resourceManager;

        private LocalizationManager()
        {
            resourceManager = new ResourceManager("ServiceMonitorEVK.Properties.Strings",
                typeof(LocalizationManager).Assembly);
            currentCulture = CultureInfo.CurrentCulture;
        }

        public static LocalizationManager Instance { get; } = new LocalizationManager();

        public string GetString(string key)
        {
            return resourceManager.GetString(key, currentCulture);
        }

        public void SetLanguage(string cultureCode)
        {
            currentCulture = new CultureInfo(cultureCode);
            Thread.CurrentThread.CurrentUICulture = currentCulture;
            Thread.CurrentThread.CurrentCulture = currentCulture;
        }

        public CultureInfo GetCurrentCulture()
        {
            return currentCulture;
        }
    }
}