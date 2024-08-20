using System.Globalization;
using System.Resources;
using System.Threading;

namespace ServiceMonitorEVK.Localization
{
    public sealed class LocalizationManager
    {
        private static readonly LocalizationManager _instance = new LocalizationManager();
        private ResourceManager _resourceManager;
        private CultureInfo _currentCulture;

        // Закрытый конструктор для реализации Singleton
        private LocalizationManager()
        {
            _resourceManager = new ResourceManager("ServiceMonitorEVK.Properties.Strings", typeof(LocalizationManager).Assembly);
            _currentCulture = CultureInfo.CurrentCulture;
        }

        public static LocalizationManager Instance => _instance;

        public string GetString(string key)
        {
            return _resourceManager.GetString(key, _currentCulture);
        }

        public void SetLanguage(string cultureCode)
        {
            _currentCulture = new CultureInfo(cultureCode);
            Thread.CurrentThread.CurrentUICulture = _currentCulture;
            Thread.CurrentThread.CurrentCulture = _currentCulture;
        }

        public CultureInfo GetCurrentCulture()
        {
            return _currentCulture;
        }
    }
}
