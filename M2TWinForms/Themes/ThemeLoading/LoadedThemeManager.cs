using MaterialTheming;

namespace M2TWinForms.Themes.ThemeLoading
{
    public class LoadedThemeManager
    {
        public ThemeColors? CurrentLoadedTheme { get; private set; }
        public bool CurrentLoadedThemeIsDark 
        {
            get
            {
                if (!IsThemeLoaded)
                    throw new InvalidOperationException("No theme loaded");
                return field;
            }
            private set;
        }

        public bool IsThemeLoaded
            => CurrentLoadedTheme is not null;

        public void LoadTheme(Theme theme)
        {
            ArgumentNullException.ThrowIfNull(theme.Colors, nameof(theme));

            CurrentLoadedTheme = theme.Colors;
            CurrentLoadedThemeIsDark = theme.IsDark;
        }

        public Color GetColorForRole(ColorRoles role)
        {
            if (!IsThemeLoaded)
                throw new InvalidOperationException("No theme loaded");

            var color = role switch
            {
                ColorRoles.Primary => CurrentLoadedTheme!.Primary,
                ColorRoles.OnPrimary => CurrentLoadedTheme!.OnPrimary,
                ColorRoles.PrimaryContainer => CurrentLoadedTheme!.PrimaryContainer,
                ColorRoles.OnPrimaryContainer => CurrentLoadedTheme!.OnPrimaryContainer,
                ColorRoles.Secondary => CurrentLoadedTheme!.Secondary,
                ColorRoles.OnSecondary => CurrentLoadedTheme!.OnSecondary,
                ColorRoles.SecondaryContainer => CurrentLoadedTheme!.SecondaryContainer,
                ColorRoles.OnSecondaryContainer => CurrentLoadedTheme!.OnSecondaryContainer,
                ColorRoles.Tertiary => CurrentLoadedTheme!.Tertiary,
                ColorRoles.OnTertiary => CurrentLoadedTheme!.OnTertiary,
                ColorRoles.TertiaryContainer => CurrentLoadedTheme!.TertiaryContainer,
                ColorRoles.OnTertiaryContainer => CurrentLoadedTheme!.OnTertiaryContainer,
                ColorRoles.Error => CurrentLoadedTheme!.Error,
                ColorRoles.OnError => CurrentLoadedTheme!.OnError,
                ColorRoles.ErrorContainer => CurrentLoadedTheme!.ErrorContainer,
                ColorRoles.OnErrorContainer => CurrentLoadedTheme!.OnErrorContainer,
                ColorRoles.Surface => CurrentLoadedTheme!.Surface,
                ColorRoles.SurfaceContainer => CurrentLoadedTheme!.SurfaceContainer,
                ColorRoles.SurfaceContainerLowest => CurrentLoadedTheme!.SurfaceContainerLowest,
                ColorRoles.SurfaceContainerLow => CurrentLoadedTheme!.SurfaceContainerLow,
                ColorRoles.SurfaceContainerHigh => CurrentLoadedTheme!.SurfaceContainerHigh,
                ColorRoles.SurfaceContainerHighest => CurrentLoadedTheme!.SurfaceContainerHighest,
                ColorRoles.OnSurface => CurrentLoadedTheme!.OnSurface,
                ColorRoles.OnSurfaceVariant => CurrentLoadedTheme!.OnSurfaceVariant,

                _ => throw new ArgumentException("Invalid color role", nameof(role)),
            };

            return GetColorFromRgbColor(color);
        }

        private static Color GetColorFromRgbColor(RgbColor rgbColor)
            => Color.FromArgb(rgbColor.Red, rgbColor.Green, rgbColor.Blue);
    }
}
