using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms
{
    public static class ImageGrayscalingExtension
    {
        public static Image GetGrayScaledImage(this Image sourceImage)
        {
            // https://www.tutorialspoint.com/dip/grayscale_to_rgb_conversion.htm
            var greyScaled = new Bitmap(sourceImage);
            for (int x = 0, loopTo = greyScaled.Width - 1; x <= loopTo; x++)
            {
                for (int y = 0, loopTo1 = greyScaled.Height - 1; y <= loopTo1; y++)
                {
                    var pixelColor = greyScaled.GetPixel(x, y);
                    byte brightnessLevel = (byte)Math.Floor(pixelColor.R * 0.3d + pixelColor.G * 0.59d + pixelColor.B * 0.11d);
                    var greyScaledColor = Color.FromArgb(pixelColor.A, brightnessLevel, brightnessLevel, brightnessLevel);
                    greyScaled.SetPixel(x, y, greyScaledColor);
                }
            }
            return greyScaled;
        }
    }
}
