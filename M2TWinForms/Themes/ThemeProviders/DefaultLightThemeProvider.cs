using MaterialTheming;
using MaterialTheming.Creation;
using MaterialTheming.MaterialDesign;

namespace M2TWinForms.Themes.ThemeProviders
{
    internal class DefaultLightThemeProvider : IThemeProvider
    {
        public Theme CreateTheme()
        {
            return ThemeBuilder
                .CreateFromSourceColor("#6D5E0F")
                .WithMode(ThemeMode.Light)
                .WithContrastLevel(ContrastLevel.Normal)
                .Build();
        }
    }
}
