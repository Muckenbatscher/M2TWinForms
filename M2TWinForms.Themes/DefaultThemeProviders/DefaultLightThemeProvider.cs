using M2TWinForms.Themes.MaterialDesign;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Themes.DefaultThemeProviders
{
    public class DefaultLightThemeProvider : DefaultThemeProvider
    {
        protected override ThemeColors CreateThemeColors()
        {
            return new ThemeColors
            {
                Primary = Color.FromArgb(109, 94, 15),
                OnPrimary = Color.FromArgb(255, 255, 255),
                PrimaryContainer = Color.FromArgb(248, 226, 136),
                OnPrimaryContainer = Color.FromArgb(83, 70, 0),
                Secondary = Color.FromArgb(102, 94, 64),
                OnSecondary = Color.FromArgb(255, 255, 255),
                SecondaryContainer = Color.FromArgb(238, 226, 188),
                OnSecondaryContainer = Color.FromArgb(77, 71, 42),
                Tertiary = Color.FromArgb(67, 102, 79),
                OnTertiary = Color.FromArgb(255, 255, 255),
                TertiaryContainer = Color.FromArgb(197, 236, 207),
                OnTertiaryContainer = Color.FromArgb(43, 78, 56),
                Error = Color.FromArgb(186, 26, 26),
                OnError = Color.FromArgb(255, 255, 255),
                ErrorContainer = Color.FromArgb(255, 218, 214),
                OnErrorContainer = Color.FromArgb(147, 0, 10),
                Surface = Color.FromArgb(255, 249, 237),
                SurfaceContainer = Color.FromArgb(244, 237, 223),
                SurfaceContainerLowest = Color.FromArgb(255, 255, 255),
                SurfaceContainerLow = Color.FromArgb(250, 243, 229),
                SurfaceContainerHigh = Color.FromArgb(238, 232, 218),
                SurfaceContainerHighest = Color.FromArgb(232, 226, 212),
                OnSurface = Color.FromArgb(30, 28, 19),
                OnSurfaceVariant = Color.FromArgb(75, 71, 57),
            };
        }
    }
}
