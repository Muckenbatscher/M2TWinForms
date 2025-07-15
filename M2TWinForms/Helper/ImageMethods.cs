using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Helper
{
    internal class ImageMethods
    {
        public static void DrawImageWithColor(Image image, Color color, Padding padding, Control control, PaintEventArgs e)
        {
            if (image == null)
                image = new Bitmap(1, 1);
            var colorMatrix = GetTransformationMatrix(color);
            var imageattributes = new ImageAttributes();
            imageattributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            var destinationRectangle = GetZoomedDestinationRectangle(control.Size, image.Size, padding);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.DrawImage(image, destinationRectangle, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageattributes);
            GC.Collect();
        }
        public static void DrawImageWithColor(Image Image, Color color, Control control, PaintEventArgs e)
        {
            DrawImageWithColor(Image, color, new Padding(0), control, e);
        }

        private static ColorMatrix GetTransformationMatrix(Color color)
        {
            float[][] colorMatrixElements =
            [
                [color.R / 255f, 0f, 0f, 0f, 0f],
                [0f, color.G / 255f, 0f, 0f, 0f],
                [0f, 0f, color.B / 255f, 0f, 0f],
                [0f, 0f, 0f, 1f, 0f],
                [0f, 0f, 0f, 0f, 1f]
            ];
            return new ColorMatrix(colorMatrixElements);
        }

        private static Rectangle GetZoomedDestinationRectangle(Size destination, Size source, Padding padding)
        {
            Size size;
            Point location;

            double actualDestinationWidth = destination.Width - padding.Left - padding.Right;
            double actualDestinationHeight = destination.Height - padding.Top - padding.Bottom;

            double ratioWidth = actualDestinationWidth / source.Width;
            double ratioHeight = actualDestinationHeight / source.Height;

            if (ratioHeight > ratioWidth) // width limited
            {
                int newHeight = (int)((double)source.Height / source.Width * actualDestinationWidth);
                size = new Size((int)actualDestinationWidth, newHeight);
                location = new Point(padding.Left, padding.Top + ((int)actualDestinationHeight - newHeight) / 2);
            }
            else // height limited
            {
                int newWidth = (int)((double)source.Width / source.Height * actualDestinationHeight);
                size = new Size(newWidth, (int)actualDestinationHeight);
                location = new Point(padding.Left + ((int)actualDestinationWidth - newWidth) / 2, padding.Top);
            }
            return new Rectangle(location, size);

        }

        public static Image GetGrayScaledImage(Image sourceImage)
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
