using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Themes.Creation
{
    public interface IThemeColors
    {
        Color Primary { get; }
        Color OnPrimary { get; }
        Color PrimaryContainer { get; }
        Color OnPrimaryContainer { get; }
        Color Secondary { get; }
        Color OnSecondary { get; }
        Color SecondaryContainer { get; }
        Color OnSecondaryContainer { get; }
        Color Tertiary { get; }
        Color OnTertiary { get; }
        Color TertiaryContainer { get; }
        Color OnTertiaryContainer { get; }
        Color Error { get; }
        Color OnError { get; }
        Color ErrorContainer { get; }
        Color OnErrorContainer { get; }
        Color Surface { get; }
        Color SurfaceContainer { get; }
        Color SurfaceContainerLowest { get; }
        Color SurfaceContainerLow { get; }
        Color SurfaceContainerHigh { get; }
        Color SurfaceContainerHighest { get; }
        Color OnSurface { get; }
        Color OnSurfaceVariant { get; }
    }
}
