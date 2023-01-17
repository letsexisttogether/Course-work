using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Model.Entities;

namespace Model.Processors
{
    public class ImageParser
    {
        public ImageParser(String imagePath)
        {
            _path = imagePath;
            DesktopImage.MainImage = File.ReadAllBytes(_path);
            SetTitle();
            SetImageFormat();
            SetWidthHeigth();
            SetSize();
        }

        private void SetTitle()
        {
            DesktopImage.ImageTitle = String
                .Concat(Path.GetFileName(_path)
                .TakeWhile(c => c != '.'));
        }
        private void SetSize()
        {
            DesktopImage.ImageSize = DesktopImage.MainImage.Length;
        }
        private void SetWidthHeigth()
        {
            using (FileStream stream = new FileStream(_path, FileMode.Open))
            {
                Image tempImage = Image.FromStream(stream);
                DesktopImage.ImageWidth = tempImage.Width;
                DesktopImage.ImageHeigth = tempImage.Height;
            }
        }
        private void SetImageFormat()
        {
            DesktopImage.ImageFormat = String
                .Concat(Path.GetExtension(_path).Remove(0, 1));
        }
       
        public static ImageFormat GetFormat(String format)
        {
            if (format == null)
            {
                throw new ArgumentNullException("Format is invalide");
            }

            if (format == "jpg")
            {
                return ImageFormat.Jpeg;
            }
            if (format == "png")
            {
                return ImageFormat.Png;
            }
      
            return ImageFormat.Bmp;
        }
        public static Image ImageFromBytes(byte[] data)
        {
            ImageConverter converter = new ImageConverter();
            return (Bitmap)converter.ConvertFrom(data);
            //using (MemoryStream ms = new MemoryStream(data))
            //{ 
            //    return (Bitmap)Image.FromStream(ms);
            //}
        }
        public static byte[] ImageToBytes(Image image, String format)
        {
            Image tempImage = new Bitmap(image);
            using (MemoryStream ms = new MemoryStream())
            {
                tempImage.Save(ms, GetFormat(format));
                return ms.ToArray();
            }
        }

        public DesktopImage DesktopImage { get; private set; } = new DesktopImage();
        private String _path;
    }
}
