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
    internal class LoadedThemeManager
    {
        public Theme CurrentLoadedTheme 
        { 
            get => _currentLoadedTheme;
            private set => _currentLoadedTheme = value;
        }
        private Theme _currentLoadedTheme;

        public Color GetColorForType(ColorType colorType)
        {
            var usage = GetColorUsageForTypeFromTheme(CurrentLoadedTheme, colorType);
            return usage.Color;
        }
        private ColorUsage GetColorUsageForTypeFromTheme(Theme theme, ColorType colorType)
        {
            return theme.Colors.FirstOrDefault(c => c.ColorType == colorType);
        }

        public void LoadTheme(Theme theme)
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
