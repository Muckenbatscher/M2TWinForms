using M2TWinForms.Themes.ThemeProviders;
using MaterialTheming;
using MaterialTheming.Creation;
using MaterialTheming.MaterialDesign;
using System.Text;

namespace M2TWinForms.Demo
{
    public class DefaultThemeProvider : IDefaultThemeProvider
    {
        public Theme CreateTheme()
        {
            return ThemeBuilder.Create()
                .WithPrimaryColor(c => c.WithBaseColor("#5CC149").WithFixedTargetChroma(true))
                .WithMode(ThemeMode.Dark)
                .Build();

            var themeContentBytes = Properties.Resources.material_theme_blue;
            var themeContent = Encoding.UTF8.GetString(themeContentBytes);

            var theme = ThemeBuilder.Create()
                .WithMaterialThemeBuilderJson(themeContent)
                .WithContrastLevel(ContrastLevel.Normal)
                .WithMode(ThemeMode.Dark)
                .Build();
            return theme;
        }
    }
}
