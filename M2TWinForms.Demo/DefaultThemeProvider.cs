using M2TWinForms.Themes;
using M2TWinForms.Themes.MaterialDesign;
using M2TWinForms.Themes.ThemeProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Demo
{
    public class DefaultThemeProvider : IDefaultThemeProvider
    {
        public Theme CreateTheme()
        {
            var theme = Theme.CreateFromSinglePrimaryColor(Color.Purple, ThemeMode.Dark, ContrastLevel.Normal, true);
            return theme;

            var themeContentBytes = Properties.Resources.material_theme_blue;
            var themeContent = Encoding.UTF8.GetString(themeContentBytes);

            var themeJson = Theme.CreateFromMaterialDesignJson(
                            themeContent, ThemeMode.Light, ContrastLevel.Normal);
            return themeJson;
        }
    }
}
