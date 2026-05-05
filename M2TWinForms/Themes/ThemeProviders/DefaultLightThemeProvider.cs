using MaterialTheming;

namespace M2TWinForms.Themes.ThemeProviders
{
    internal class DefaultLightThemeProvider : IThemeProvider
    {
        public Theme CreateTheme()
        {
            var color = GetRgbColor(Color.Khaki);
            var colors = ThemeBuilder.CreateFromSourceColor(color)
                .WithMode(ThemeMode.Light)
                .WithContrastLevel(ContrastLevel.Normal)
                .WithVariant(Variant.TonalSpot)
                .Build();
            return new Theme(isDark: false, colors: colors);
        }

        private static RgbColor GetRgbColor(Color color)
        {
            return RgbColor.FromRgb(color.R, color.G, color.B);
        }
    }
}
