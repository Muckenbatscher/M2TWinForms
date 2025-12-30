using M2TWinForms.Themes.ThemeProviders;
using MaterialTheming;
using MaterialTheming.Creation;
using MaterialTheming.MaterialDesign;

namespace M2TWinForms.Demo
{
    public class DefaultThemeProvider : IDefaultThemeProvider
    {
        public Theme CreateTheme()
        {
            var primaryColor = Color.Green;
            var theme = ThemeBuilder.Create()
                .WithPrimaryColor(c => c.WithBaseColor(primaryColor.R, primaryColor.G, primaryColor.B))
                .WithContrastLevel(ContrastLevel.Normal)
                .WithMode(ThemeMode.Dark)
                .Build();
            return theme;
        }
    }
}
