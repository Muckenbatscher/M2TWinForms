using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Helper
{
    internal class ColorTranslation
    {
        public static string HexStringFromColor(Color color)
        {
            return $"#{color.R:X2}{color.G:X2}{color.B:X2}".ToUpper();
        }

        public static Color ColorFromHexString(string hexString)
        {
            if (hexString == null)
                throw new ArgumentNullException(nameof(hexString));
            if (hexString.StartsWith("#"))
                hexString = hexString.Substring(1);
            if (hexString.Length < 6)
                throw new ArgumentException();
            if (hexString.Length == 8)
                hexString = hexString.Substring(2);
            if (hexString.Length != 6)
                throw new ArgumentException();

            string redString = hexString.Substring(0, 2);
            string greenString = hexString.Substring(2,2);
            string blueString = hexString.Substring(4, 2);
            byte red = byte.Parse(redString, System.Globalization.NumberStyles.HexNumber);
            byte green = byte.Parse(greenString, System.Globalization.NumberStyles.HexNumber);
            byte blue = byte.Parse(blueString, System.Globalization.NumberStyles.HexNumber);

            return Color.FromArgb(red, green, blue);
        }
    }
}
