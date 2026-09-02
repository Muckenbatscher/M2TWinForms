using MaterialTheming;

namespace M2TWinForms.Themes.ThemeProviders
{
    internal class DefaultLightThemeProvider : IThemeProvider
    {
        public Theme CreateTheme()
        {
            var color = Color.Khaki.ToRgbColor();
            var colors = ThemeBuilder.CreateFromSourceColor(color)
                .WithMode(ThemeMode.Light)
                .WithContrastLevel(ContrastLevel.Normal)
                .WithVariant(Variant.TonalSpot)
                .Build();
            return new Theme(isDark: false, colors: colors);
        }
    }
}
