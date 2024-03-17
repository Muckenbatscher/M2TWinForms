using M2TWinForms.Enumerations;
using M2TWinForms.Interfaces;
using M2TWinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Services.DefaultTheme
{
    public class DefaultDarkThemeService : IDefaultThemeGenerationService
    {
        public string ThemeName => "Default";

        public Dictionary<ColorType, string> ColorMap
        {
            get
            {
                return new Dictionary<ColorType, string> 
                {
                    { ColorType.ForegroundPrimary, "#ffffff" },
                    { ColorType.ForegroundSecondary, "#cccccc" },
                    { ColorType.ForegroundTertiary, "#999999" },
                    { ColorType.BackgroundPrimary, "#0c0c0d" },
                    { ColorType.BackgroundSecondary, "#1e1e21" },
                    { ColorType.BackgroundTertiarty, "#313136" },
                    { ColorType.HighlightForegroundPrimary, "#58db56" },
                    { ColorType.HighlightForegroundSecondary, "#247823" },
                    { ColorType.HighlightBackgroundPrimary, "#3dab3c" },
                    { ColorType.HighlightBackgroundSecondary, "#336e32" },
                    { ColorType.PositiveConfirmationBackgroundColor, "#61c977" },
                    { ColorType.PositiveConfirmationForegroundColor, "#0a3614" },
                    { ColorType.NegativeConfirmationBackgroundColor, "#d43833" },
                    { ColorType.NegativeConfirmationForegroundColor, "#470d0b" }
                };
            }
        }

        public Theme GetTheme()
        {
            return ThemeGenerationService.GenerateTheme(ThemeName, ColorMap);
        }
    }
}
