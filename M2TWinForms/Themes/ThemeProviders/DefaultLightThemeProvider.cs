using MaterialTheming;

namespace M2TWinForms.Themes.ThemeProviders
{
    internal class DefaultLightThemeProvider : IThemeProvider
    {
        public Theme CreateTheme()
        {
            var colors = ThemeBuilder
                .CreateFromSourceColor("#6D5E0F")
                .WithMode(ThemeMode.Light)
                .WithContrastLevel(ContrastLevel.Normal)
                .Build();
            return new Theme(false, colors);
        }
    }
}
