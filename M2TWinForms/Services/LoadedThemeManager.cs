using M2TWinForms.Enumerations;
using M2TWinForms.Models;
using M2TWinForms.Services.DefaultTheme;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Services
{
    public class LoadedThemeManager
    {
        public static Theme CurrentLoadedTheme 
        { 
            get
            {
                if (_currentLoadedTheme == null)
                {
                    var darkThemeService = new DefaultDarkThemeService();
                    _currentLoadedTheme = darkThemeService.GetTheme();
                }
                return _currentLoadedTheme;
            }
            private set => _currentLoadedTheme = value;
        }
        private static Theme _currentLoadedTheme;

        public static Color GetColorForType(ColorType colorType)
        {
            var usage = GetColorUsageForTypeFromTheme(CurrentLoadedTheme, colorType);
            return usage.Color;
        }
        private static ColorUsage GetColorUsageForTypeFromTheme(Theme theme, ColorType colorType)
        {
            return theme.Colors.FirstOrDefault(c => c.ColorType == colorType);
        }

        public static void LoadTheme(Theme theme)
        {
            if (theme == null)
                throw new ArgumentNullException(nameof(theme));

            foreach (ColorType type in Enum.GetValues(typeof(ColorType)))
            {
                var colorUsage = GetColorUsageForTypeFromTheme(theme, type);
                if (colorUsage == null)
                    throw new ArgumentException($"Missing Value for ColorType: {type}");
            }
            CurrentLoadedTheme = theme;
        }
    }
}
