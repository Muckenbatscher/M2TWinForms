using M2TWinForms.Themes;
using M2TWinForms.Themes.MaterialDesign;
using M2TWinForms.Themes.ThemeProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Demo
{
    public class DefaultThemeProvider : IDefaultThemeProvider
    {
        public Theme CreateTheme()
        {
            var theme = Theme.CreateFromSinglePrimaryColor(
                Color.Green, ThemeMode.Light, ContrastLevel.Normal, true);
            return theme;
        }
    }
}
