using M2TWinForms.Enumerations;
using M2TWinForms.Interfaces.DefaultTheme;
using M2TWinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Services.DefaultTheme.Provider
{
    public class DefaultDarkThemeProvider : IDefaultThemeProvider
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
                    { ColorType.ForegroundHoverPrimary, "#f0f0f0" },
                    { ColorType.ForegroundHoverSecondary, "#c0c0c0" },
                    { ColorType.ForegroundHoverTertiary, "#909090" },
                    { ColorType.BackgroundPrimary, "#0c0c0d" },
                    { ColorType.BackgroundSecondary, "#1e1e21" },
                    { ColorType.BackgroundTertiarty, "#313146" },
                    { ColorType.BackgroundHoverPrimary, "#0a0c0b" },
                    { ColorType.BackgroundHoverSecondary, "#1c1e1e" },
                    { ColorType.BackgroundHoverTertiarty, "#2e3144" },
                    { ColorType.HighlightForegroundPrimary, "#58db56" },
                    { ColorType.HighlightForegroundSecondary, "#247823" },
                    { ColorType.HighlightBackgroundPrimary, "#3dab3c" },
                    { ColorType.HighlightBackgroundSecondary, "#336e32" },
                    { ColorType.HighlightHoverForegroundPrimary, "#59dc57" },
                    { ColorType.HighlightHoverForegroundSecondary, "#257924" },
                    { ColorType.HighlightHoverBackgroundPrimary, "#3aa03a" },
                    { ColorType.HighlightHoverBackgroundSecondary, "#316c30" },
                    { ColorType.PositiveConfirmationBackground, "#61c977" },
                    { ColorType.PositiveConfirmationForeground, "#0a3614" },
                    { ColorType.PositiveConfirmationHoverBackground, "#5ec775" },
                    { ColorType.PositiveConfirmationHoverForeground, "#0b3715" },
                    { ColorType.NegativeConfirmationBackground, "#d43833" },
                    { ColorType.NegativeConfirmationForeground, "#470d0b" },
                    { ColorType.NegativeConfirmationHoverBackground, "#d23631" },
                    { ColorType.NegativeConfirmationHoverForeground, "#480e0c" }
                };
            }
        }

        public Theme GetTheme()
        {
            return ThemeGenerationService.GenerateTheme(ThemeName, ColorMap);
        }
    }
}
