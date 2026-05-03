using System.Drawing.Imaging;

namespace M2TWinForms.Helper
{
    /// <summary>
    /// Provides helper methods for icon manipulation. Especially Icons and Images.
    /// </summary>
    public static class IconHelper
    {
        /// <summary>
        /// Converts a PNG image to a icon (ico)
        /// </summary>
        /// <param name="input">The input stream</param>
        /// <param name="output">The output stream</param>
        /// <param name="size">The size (16x16 px by default)</param>
        /// <param name="preserveAspectRatio">Preserve the aspect ratio</param>
        /// <returns>Wether or not the icon was succesfully generated</returns>
        public static bool ConvertToIcon(Stream input, Stream output, int size = 16, bool preserveAspectRatio = false)
        {
            Bitmap inputBitmap = (Bitmap)Bitmap.FromStream(input);
            if (inputBitmap != null)
            {
                int width, height;
                if (preserveAspectRatio)
                {
                    width = size;
                    height = inputBitmap.Height / inputBitmap.Width * size;
                }
                else
                {
                    width = height = size;
                }
                Bitmap newBitmap = new Bitmap(inputBitmap, new Size(width, height));
                if (newBitmap != null)
                    return SaveBitmapAsIcon(newBitmap, output);

                return false;
            }
            return false;
        }

        private static bool SaveBitmapAsIcon(Bitmap bitmap, Stream output)
        {
            using MemoryStream ms = new MemoryStream();
            bitmap.Save(ms, ImageFormat.Png);
            byte[] pngData = ms.ToArray();

            var iconWriter = new BinaryWriter(output);

            // Header: Reserved (0), Type (1 = Icon), Count (1 Image)
            iconWriter.Write((short)0);
            iconWriter.Write((short)1);
            iconWriter.Write((short)1);

            // Directory Entry
            iconWriter.Write((byte)bitmap.Width);
            iconWriter.Write((byte)bitmap.Height);
            iconWriter.Write((byte)0); // Colors
            iconWriter.Write((byte)0); // Reserved
            iconWriter.Write((short)0); // Planes
            iconWriter.Write((short)32); // Bits per Pixel
            iconWriter.Write((int)pngData.Length); // Size of data
            iconWriter.Write((int)(6 + 16)); // Offset (Header + 1 Entry)

            // Raw PNG Data
            iconWriter.Write(pngData);
            iconWriter.Flush();
            return true;
        }

        /// <summary>
        /// Converts a PNG image to a icon (ico)
        /// </summary>
        /// <param name="inputPath">The input path</param>
        /// <param name="outputPath">The output path</param>
        /// <param name="size">The size (16x16 px by default)</param>
        /// <param name="preserveAspectRatio">Preserve the aspect ratio</param>
        /// <returns>Wether or not the icon was succesfully generated</returns>
        public static bool ConvertToIcon(string inputPath, string outputPath, int size = 16, bool preserveAspectRatio = false)
        {
            using (FileStream inputStream = new FileStream(inputPath, FileMode.Open))
            using (FileStream outputStream = new FileStream(outputPath, FileMode.OpenOrCreate))

            return ConvertToIcon(inputStream, outputStream, size, preserveAspectRatio);
        }

        /// <summary>
        /// Konvertiert eine Image-Instanz in ein Icon (ico)
        /// </summary>
        /// <param name="image">Die Quell-Image Instanz</param>
        /// <param name="output">Der Ziel-Stream</param>
        /// <param name="size">Die Zielgröße (Standard 16x16 px)</param>
        /// <param name="preserveAspectRatio">Seitenverhältnis beibehalten</param>
        /// <returns>True, wenn das Icon erfolgreich erstellt wurde</returns>
        public static bool ConvertToIcon(Image image, Stream output, int size = 16, bool preserveAspectRatio = false)
        {
            if (image == null) return false;

            int width, height;
            if (preserveAspectRatio)
            {
                width = size;
                height = (int)((double)image.Height / image.Width * size);
            }
            else
            {
                width = height = size;
            }

            using (Bitmap resizedBitmap = new Bitmap(image, new Size(width, height)))
            {
                return SaveBitmapAsIcon(resizedBitmap, output);
            }
        }
        /// <summary>
        /// Erstellt eine Icon-Instanz direkt aus einem Image, ohne eine Datei auf der Festplatte zu speichern.
        /// </summary>
        /// <param name="image">Das Quellbild</param>
        /// <param name="size">Die gewünschte Größe</param>
        /// <returns>Eine neue Icon-Instanz</returns>
        public static Icon CreateIconFromImage(Image image, int size = 16)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Wir nutzen deine bestehende Methode, um die ICO-Daten in den MemoryStream zu schreiben
                if (ConvertToIcon(image, ms, size, false))
                {
                    // WICHTIG: Den Stream-Pointer zurück auf den Anfang setzen, damit die Icon-Klasse ihn lesen kann
                    ms.Position = 0;
                    return new Icon(ms);
                }
            }
            return null;
        }
    }
}
