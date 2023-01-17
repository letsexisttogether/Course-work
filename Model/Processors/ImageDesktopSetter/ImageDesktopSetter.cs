using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using Model.Entities;



namespace Model.Processors
{
    public class ImageDesktopSetter
    {
        public ImageDesktopSetter(Image image, String title, String format)
        {
            _imageToSet = image;
            _imageTitle = title;
            _imageFormat = format;

            _imageStyles = new Dictionary<String, Action<RegistryKey>>()
            {
                ["Розтягнуте"] = (RegistryKey key) =>
                {
                    key.SetValue(@"WallpaperStyle", "10");
                    key.SetValue(@"TileWallpaper", "0");
                },

                ["Центроване"] = (RegistryKey key) =>
                {
                    key.SetValue(@"WallpaperStyle", "1");
                    key.SetValue(@"TileWallpaper", "0");
                },

                ["Зжате"] = (RegistryKey key) =>
                {
                    key.SetValue(@"WallpaperStyle", "6");
                    key.SetValue(@"TileWallpaper", "0");
                },

                ["Підтягнуте"] = (RegistryKey key) =>
                {
                    key.SetValue(@"WallpaperStyle", "4");
                    key.SetValue(@"TileWallpaper", "1");
                }
            };
        }

        public SetResult SetWallpaper(String style)
        {
            if (_imageToSet == null)
            {
                return SetResult.Unrecognized_image;
            }

            try
            {
                String path = ImageFileProcessor.SaveImage(_imageToSet, _imageTitle, _imageFormat);

                if (path == String.Empty)
                {
                    return SetResult.Unrecognized_image;
                }

                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
                try
                {
                    _imageStyles[style].Invoke(key);
                }
                catch
                {
                    return SetResult.Style_not_found;
                }

                SystemParametersInfo(SPI_SETDESKWALLPAPER, 0x0, path, 
                    SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
            }
            catch
            {
                return SetResult.Unrecognized_image;
            }

            return SetResult.Success;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        private const int SPI_SETDESKWALLPAPER = 0x14;
        private const int SPIF_UPDATEINIFILE = 0x01;
        private const int SPIF_SENDWININICHANGE = 0x02;

        private Image _imageToSet;
        private String _imageTitle;
        private String _imageFormat;
        private Dictionary<String, Action<RegistryKey>> _imageStyles;
    }
}
