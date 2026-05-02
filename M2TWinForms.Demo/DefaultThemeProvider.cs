using M2TWinForms.Themes;
using M2TWinForms.Themes.ThemeProviders;
using MaterialTheming;
using System.Text;

namespace M2TWinForms.Demo
{
    public class DefaultThemeProvider : IDefaultThemeProvider
    {
        public Theme CreateTheme()
        {
            var colors = ThemeBuilder.CreateFromSourceColor(HctColor.From(160, 80, 40))
                .WithContrastLevel(ContrastLevel.Normal)
                .WithMode(ThemeMode.Dark)
                .WithVariant(Variant.TonalSpot)
                .Build();
            return new Theme(colors, isDark: true);

            var themeContentBytes = Properties.Resources.material_theme_blue;
            var themeContent = Encoding.UTF8.GetString(themeContentBytes);

            var themeBuilderColors = ThemeBuilder
                .CreateFromJsonContent(themeContent)
                .WithContrastLevel(ContrastLevel.Normal)
                .WithMode(ThemeMode.Dark)
                .Build();
            return new Theme(themeBuilderColors, isDark: true);
        }
    }
}
