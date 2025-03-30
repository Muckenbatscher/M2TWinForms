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
            var primaryColorHct = new HctColor(primaryColor) { Chroma = 32, Tone = 50 };
            var seconaryColorHct = new HctColor(primaryColorHct.Hue, 16, 50);
            var tertiaryColorHct = new HctColor(primaryColorHct.Hue + 60, 24, 50);
            var errorColorHct = new HctColor(24, 85, 50);
            var neutralColorHct = new HctColor(primaryColorHct.Hue, 5, 50);
            var neutralVariantColorHct = new HctColor(primaryColorHct.Hue, 8, 50);

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
