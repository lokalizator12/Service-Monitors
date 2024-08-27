using System;
using System.Drawing;

namespace ServiceMonitorEVK.Util_Managers
{
    public static class ThemeManager
    {
        public static event Action ThemeChanged;
        public static event Action<Color> LogoBackColorChanged;

        private static bool _isDarkTheme;
        public static bool IsDarkTheme
        {
            get => _isDarkTheme;
            set
            {
                if (_isDarkTheme != value)
                {
                    _isDarkTheme = value;
                    OnThemeChanged();
                    OnLogoBackColorChanged();
                }
            }
        }

        public static Color LogoBackColor => IsDarkTheme ? Color.FromArgb(0x21, 0x21, 0x21) : Color.FromArgb(0x37, 0x47, 0x4F);

        private static void OnThemeChanged()
        {
            ThemeChanged?.Invoke();
        }

        private static void OnLogoBackColorChanged()
        {
            LogoBackColorChanged?.Invoke(LogoBackColor);
        }
    }
}