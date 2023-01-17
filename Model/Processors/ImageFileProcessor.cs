using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using Model.Entities;

namespace Model.Processors
{
    public static class ImageFileProcessor
    {
        public static DesktopImage OpenImageFromFile(String filter) // "JPG|*.jpg|PNG|*.png" 
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = filter;
            openFileDialog.ShowDialog();

            String fileName = openFileDialog.FileName;

            if (fileName == String.Empty)
            {
                return null;
            }

            ImageParser parser = new ImageParser(fileName);

            DesktopImage image = parser.DesktopImage;

            return image;
        }

        public static String SaveImage(Image image, String title, String format)
        {
            string tempPath = Path.Combine(Path.GetTempPath(), 
                title + "." + format);
            image.Save(tempPath, ImageParser.GetFormat(format));

            return tempPath;
        }

        public static byte[] GetImageFromFile(String filePath)
        {
            if (filePath == String.Empty)
            {
                return null;
            }
            return File.ReadAllBytes(filePath);
        }
    }
}
