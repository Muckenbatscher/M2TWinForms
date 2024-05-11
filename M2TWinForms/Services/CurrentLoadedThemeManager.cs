using M2TWinForms.Enumerations;
using M2TWinForms.Models;
using M2TWinForms.Services.DefaultTheme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Services
{
    public class CurrentLoadedThemeManager
    {
        public static Theme CurrentLoadedTheme
        {
            get
            {
                var instance = GetLoadedThemeManagerInstance();
                return instance.CurrentLoadedTheme;
            }
        }

        private static LoadedThemeManager _themeManagerInstance;
        private static LoadedThemeManager GetLoadedThemeManagerInstance()
        {
            if (_themeManagerInstance == null)
            {
                _themeManagerInstance = new LoadedThemeManager();
                var darkThemeService = new DefaultDarkThemeService();
                _themeManagerInstance.LoadTheme(darkThemeService.GetTheme());
            }

            return _themeManagerInstance;
        }

        public static Color GetColorForType(ColorType colorType)
        {
            var instance = GetLoadedThemeManagerInstance();
            return instance.GetColorForType(colorType);
        }

        public static void LoadTheme(Theme theme)
        {
            var instance = GetLoadedThemeManagerInstance();
            instance.LoadTheme(theme);
        }
    }
}
