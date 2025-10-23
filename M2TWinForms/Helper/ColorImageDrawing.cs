using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms
{
    public static class ColorImageDrawingExtensions
    {
        public static void PrepareGraphicsForHighQualityDrawing(this Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
        }

        public static void DrawImageWithColor(this Graphics g, Image Image, Color color, Control control)
        {
            g.DrawImageWithColor(Image, color, new Padding(0), control);
        }
        public static void DrawImageWithColor(this Graphics g, Image image, Color color, Padding padding, Control control)
        {
            var destinationRectangle = GetZoomedDestinationRectangle(control.Size, image.Size, padding);
            g.DrawImageWithColor(image, color, destinationRectangle);
        }
        public static void DrawImageWithColor(this Graphics g, Image image, Color color, Padding padding, Rectangle rectangle)
        {
            var destinationRectangle = GetZoomedDestinationRectangle(rectangle.Size, image.Size, padding);
            g.DrawImageWithColor(image, color, destinationRectangle);
        }
        public static void DrawImageWithColor(this Graphics g, Image image, Color color, Rectangle destinationRectangle)
        {
            image ??= new Bitmap(1, 1);
            var colorMatrix = GetTransformationMatrix(color);
            var imageattributes = new ImageAttributes();
            imageattributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            g.DrawImage(image, destinationRectangle, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageattributes);
            GC.Collect();
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
            double actualDestinationWidth = destination.Width - padding.Left - padding.Right;
            double actualDestinationHeight = destination.Height - padding.Top - padding.Bottom;

            double ratioWidth = actualDestinationWidth / source.Width;
            double ratioHeight = actualDestinationHeight / source.Height;

            if (ratioHeight > ratioWidth) // width limited
            {
                int newHeight = (int)((double)source.Height / source.Width * actualDestinationWidth);
                var size = new Size((int)actualDestinationWidth, newHeight);
                var location = new Point(padding.Left, padding.Top + ((int)actualDestinationHeight - newHeight) / 2);
                return new Rectangle(location, size);
            }
            else // height limited
            {
                int newWidth = (int)((double)source.Width / source.Height * actualDestinationHeight);
                var size = new Size(newWidth, (int)actualDestinationHeight);
                var location = new Point(padding.Left + ((int)actualDestinationWidth - newWidth) / 2, padding.Top);
                return new Rectangle(location, size);
            }
        }
    }
}
