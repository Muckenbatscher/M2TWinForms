using M2TWinForms.Themes.DefaultThemeProviders;
using M2TWinForms.Themes.MaterialDesign;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Themes.ThemeLoading
{
    public class CurrentLoadedThemeManager
    {
        private static LoadedThemeManager? _themeManagerInstance;
        private static LoadedThemeManager GetLoadedThemeManagerInstance()
        {
            if (_themeManagerInstance == null)
            {
                _themeManagerInstance = new LoadedThemeManager();
            }
            if (!_themeManagerInstance.IsThemeLoaded)
            {
                var provider = new DefaultLightThemeProvider();
                var theme = provider.CreateTheme();
                _themeManagerInstance.LoadTheme(theme);
            }

            return _themeManagerInstance;
        }

        public static Color GetColorForRole(ColorRoles role)
        {
            var instance = GetLoadedThemeManagerInstance();
            return instance.GetColorForRole(role);
        }

        public static void LoadTheme(Theme theme)
        {
            var instance = GetLoadedThemeManagerInstance();
            instance.LoadTheme(theme);
        }
    }
}
