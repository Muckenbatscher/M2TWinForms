using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Themes.Creation
{
    public interface IColorPalette
    {
        Color Zero { get; }
        Color Ten { get; }
        Color Twenty { get; }
        Color Thirty { get; }
        Color Forty { get; }
        Color Fifty { get; }
        Color Sixty { get; }
        Color Seventy { get; }
        Color Eighty { get; }
        Color Ninety { get; }
        Color NinetyFive { get; }
        Color NinetyEight { get; }
        Color NinetyNine { get; }
        Color Hundred { get; }
    }
}
