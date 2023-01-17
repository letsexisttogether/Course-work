using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entities;
using System.Windows.Forms;


namespace Model.Processors
{
    public class ImagesSorter
    {
        public ImagesSorter()
        {
            _allowedSorts = new Dictionary<String, Func<IEnumerable<DesktopImage>,
                Boolean, IEnumerable<DesktopImage>>>();

            _allowedSorts.Add("Назва",
                (IEnumerable<DesktopImage> images, Boolean isAsc) =>
                {
                    return isAsc ?
                        images.OrderBy(img => img.ImageTitle) :
                        images.OrderByDescending(img => img.ImageTitle);
                });
            _allowedSorts.Add("Розмір",
                (IEnumerable<DesktopImage> images, Boolean isAsc) =>
                {
                    return isAsc ?
                        images.OrderBy(img => img.ImageSize) :
                        images.OrderByDescending(img => img.ImageSize);
                });
            _allowedSorts.Add("Розширення",
                (IEnumerable<DesktopImage> images, Boolean isAsc) =>
                {
                    return isAsc ?
                        images.OrderBy(img => img.ImageWidth + img.ImageHeigth) :
                        images.OrderByDescending(img => img.ImageWidth + img.ImageHeigth);

                });
            _allowedSorts.Add("Дата додавання",
                (IEnumerable<DesktopImage> images, Boolean isAsc) =>
                {
                    return isAsc ?
                        images.OrderBy(img => img.ImageWidth + img.ImageHeigth) :
                        images.OrderByDescending(img => img.ImageWidth + img.ImageHeigth);

                });
        }

        public IEnumerable<DesktopImage> Sort(IEnumerable<DesktopImage> images, 
            String sortFild)
        {
            try
            {
                 return _allowedSorts[sortFild]
                    .Invoke(images, IsAsc);
            }
            catch
            {
                return images;
            }
        }

        public Boolean IsAsc { get; set; } = true;
        private Dictionary<String, Func<IEnumerable<DesktopImage>,
            Boolean, IEnumerable<DesktopImage>>> _allowedSorts;
    }
}
