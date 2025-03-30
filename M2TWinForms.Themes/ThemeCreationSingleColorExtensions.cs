using M2TWinForms.Themes.MaterialDesign;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Themes
{
    partial class Theme
    {
        public static Theme CreateFromSinglePrimaryColor(Color primaryColor, ThemeMode mode, ContrastLevel contrastLevel)
        {
            var primaryColorHct = new HctColor(primaryColor);
            var seconaryColorHct = new HctColor(primaryColorHct.Hue, primaryColorHct.Chroma - 50, primaryColorHct.Tone);
            var tertiaryColorHct = new HctColor(primaryColorHct.Hue + 60, 24, primaryColorHct.Tone);
            var errorColorHct = new HctColor(20, 55, primaryColorHct.Tone);
            var neutralColorHct = new HctColor(primaryColorHct.Hue, 5, primaryColorHct.Tone);
            var neutralVariantColorHct = new HctColor(primaryColorHct.Hue, 10, primaryColorHct.Tone);

            var coreColors = new CoreColors()
            {
                Primary = primaryColorHct.GetColor(),
                Secondary = seconaryColorHct.GetColor(),
                Tertiary = tertiaryColorHct.GetColor(),
                Error = errorColorHct.GetColor(),
                Neutral = neutralColorHct.GetColor(),
                NeutralVariant = neutralVariantColorHct.GetColor()
            };

            return Theme.CreateFromCoreColors(coreColors, mode, contrastLevel);
        }
    }
}
