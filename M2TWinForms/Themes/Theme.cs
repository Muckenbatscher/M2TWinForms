using MaterialTheming;

namespace M2TWinForms.Themes;

public record struct Theme
{
    public ThemeColors Colors { get; set; }
    public bool IsDark { get; set; }

    public Theme(ThemeColors colors, bool isDark)
    {
        Colors = colors;
        IsDark = isDark;
    }
}
