using MaterialTheming;

namespace M2TWinForms.Themes.ThemeLoading
{
    public class LoadedThemeManager
    {
        public Theme? CurrentLoadedTheme { get; private set; }
        public bool IsThemeLoaded
            => CurrentLoadedTheme != null;

        public void LoadTheme(Theme theme)
        {
            ArgumentNullException.ThrowIfNull(theme, nameof(theme));

            CurrentLoadedTheme = theme;
        }

        public Color GetColorForRole(ColorRoles role)
        {
            if (!IsThemeLoaded)
                throw new InvalidOperationException("No theme loaded");

            var color = role switch
            {
                ColorRoles.Primary => CurrentLoadedTheme!.Colors.Primary,
                ColorRoles.OnPrimary => CurrentLoadedTheme!.Colors.OnPrimary,
                ColorRoles.PrimaryContainer => CurrentLoadedTheme!.Colors.PrimaryContainer,
                ColorRoles.OnPrimaryContainer => CurrentLoadedTheme!.Colors.OnPrimaryContainer,
                ColorRoles.Secondary => CurrentLoadedTheme!.Colors.Secondary,
                ColorRoles.OnSecondary => CurrentLoadedTheme!.Colors.OnSecondary,
                ColorRoles.SecondaryContainer => CurrentLoadedTheme!.Colors.SecondaryContainer,
                ColorRoles.OnSecondaryContainer => CurrentLoadedTheme!.Colors.OnSecondaryContainer,
                ColorRoles.Tertiary => CurrentLoadedTheme!.Colors.Tertiary,
                ColorRoles.OnTertiary => CurrentLoadedTheme!.Colors.OnTertiary,
                ColorRoles.TertiaryContainer => CurrentLoadedTheme!.Colors.TertiaryContainer,
                ColorRoles.OnTertiaryContainer => CurrentLoadedTheme!.Colors.OnTertiaryContainer,
                ColorRoles.Error => CurrentLoadedTheme!.Colors.Error,
                ColorRoles.OnError => CurrentLoadedTheme!.Colors.OnError,
                ColorRoles.ErrorContainer => CurrentLoadedTheme!.Colors.ErrorContainer,
                ColorRoles.OnErrorContainer => CurrentLoadedTheme!.Colors.OnErrorContainer,
                ColorRoles.Surface => CurrentLoadedTheme!.Colors.Surface,
                ColorRoles.SurfaceContainer => CurrentLoadedTheme!.Colors.SurfaceContainer,
                ColorRoles.SurfaceContainerLowest => CurrentLoadedTheme!.Colors.SurfaceContainerLowest,
                ColorRoles.SurfaceContainerLow => CurrentLoadedTheme!.Colors.SurfaceContainerLow,
                ColorRoles.SurfaceContainerHigh => CurrentLoadedTheme!.Colors.SurfaceContainerHigh,
                ColorRoles.SurfaceContainerHighest => CurrentLoadedTheme!.Colors.SurfaceContainerHighest,
                ColorRoles.OnSurface => CurrentLoadedTheme!.Colors.OnSurface,
                ColorRoles.OnSurfaceVariant => CurrentLoadedTheme!.Colors.OnSurfaceVariant,

                _ => throw new ArgumentException("Invalid color role", nameof(role)),
            };

            return GetColorFromRgbColor(color);
        }

        private Color GetColorFromRgbColor(RgbColor rgbColor)
            => Color.FromArgb(rgbColor.Red, rgbColor.Green, rgbColor.Blue);

        public bool IsDarkTheme()
            => CurrentLoadedTheme!.IsDark;
    }
}
