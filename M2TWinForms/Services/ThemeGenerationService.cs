using M2TWinForms.Enumerations;
using M2TWinForms.Helper;
using M2TWinForms.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Services
{
    internal class ThemeGenerationService
    {

        internal static Theme GenerateTheme(string name, Dictionary<ColorType, string> colors)
        {
            var colorUsages = new List<ColorUsage>();
            foreach (ColorType type in Enum.GetValues(typeof(ColorType)))
            {
                var colorUsage = GetColorUsage(type, colors);
                colorUsages.Add(colorUsage);
            }
            return new Theme()
            {
                Name = name,
                Colors = colorUsages
            };
        }

        private static ColorUsage GetColorUsage(ColorType type, Dictionary<ColorType, string> colors)
        {
            var color = GetColorForType(type, colors);
            return new ColorUsage() { Color = color, ColorType = type };
        }

        private static Color GetColorForType(ColorType type, Dictionary<ColorType, string> colors)
        {
            string colorHex = colors[type];
            return ColorTranslation.ColorFromHexString(colorHex);
        }
    }
}
