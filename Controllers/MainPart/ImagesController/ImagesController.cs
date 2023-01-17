using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using Model.SQL;
using Model.Entities;

using Model.Processors;


namespace Controllers.MainPart
{
    public class ImagesController
    {
        public ImagesController()
        {
            UpdateImages();
        }

        // Delete
        public DeleteResult DeleteCurrent()
        {
            try
            {
                _desktopImageHandler.DeleteImage(_images.ElementAt(_selectedIndex));
                return DeleteResult.Success;
            }
            catch
            {
                return DeleteResult.Failure;
            }
        }

        // Get
        public IEnumerable<Image> GetImages()
        {
            return _images
                .Select(image => ImageParser
                .ImageFromBytes(image.MainImage));
        }

        public IEnumerable<String> GetAllLabels()
        {
            return _labelHandler.GetAllLabelsTitles();
        }
        public Int32 GetCurrentId()
        {
            if (!CheckIndexCorrectness())
            {
                return -1;
            }

            return _images.ElementAt(_selectedIndex).ImageId;
        }
        public Image GetCurrentSelected()
        {
            if (!CheckIndexCorrectness())
            {
                return null;
            }

            return ImageParser.ImageFromBytes(
                _images.ElementAt(_selectedIndex).MainImage);
        }
        public String GetCurrentTitle()
        {
            if (!CheckIndexCorrectness())
            {
                return String.Empty;
            }

            return _images.ElementAt(_selectedIndex).ImageTitle;
        }
        public String GetCurrentFormat()
        {
            if (!CheckIndexCorrectness())
            {
                return String.Empty;
            }

            return _images.ElementAt(_selectedIndex).ImageFormat;
        }
        public Int32 GetCurrentSize()
        {
            if (!CheckIndexCorrectness())
            {
                return 0;
            }

            return _images.ElementAt(_selectedIndex).ImageSize;
        }
        public Int32 GetCurrentWidth()
        {
            if (!CheckIndexCorrectness())
            {
                return 0;
            }

            return _images.ElementAt(_selectedIndex).ImageWidth;
        }
        public Int32 GetCurrentHeight()
        {
            if (!CheckIndexCorrectness())
            {
                return 0;
            }

            return _images.ElementAt(_selectedIndex).ImageHeigth;
        }
        public DateTime GetCurrentDateAddDB()
        {
            if (!CheckIndexCorrectness())
            {
                return DateTime.MinValue;
            }

            return _images.ElementAt(_selectedIndex).ImageAddDate;
        }
        public Double GetCurrentAvgRating()
        {
            if (!CheckIndexCorrectness())
            {
                return 0.0;
            }

            return _udiHandler.GetDesktopImageAvgRating(
                _images.ElementAt(_selectedIndex).ImageId);
        }
        public String GetCurrentAuthorLogin()
        {
            if (!CheckIndexCorrectness())
            {
                return String.Empty;
            }

            Author author = _authorHandler.GetEntityById(
               _images.ElementAt(_selectedIndex).AuthorId);

            if (author == null)
            {
                return String.Empty;
            }

            return new AccountController(author.AccountId).GetLogin();
        }

        // Update 
        public void UpdateImages()
        {
            _images = _desktopImageHandler.GetAllImages();
        }
        public void UpdateImagesByTitle(String title)
        {
            if (title == String.Empty)
            {
                UpdateImages();
                return;
            }

            _images = _images.Where(img => img.ImageTitle.Contains(title));
        }
        public void UpdateImagesByAuthorId(Int32 id)
        {
            _images = _images.Where(img => img.AuthorId == id);
        }
        public void UpdateImagesByUserId(Int32 id)
        {
            _images = _images.Where(img => _udiHandler
                .FindUserDesktopImageById(id, img.ImageId) != -1)
                .Select(img => img);
        }
        public void UpdateIndex(Int32 index)
        {
            _selectedIndex = index;
        }
        public void MakeIndexBigger()
        {
            ++_selectedIndex;

            if (_selectedIndex >= _images.Count())
            {
                _selectedIndex = 0;
            }
        }
        public void MakeIndexSmaller()
        {
            --_selectedIndex;

            if (_selectedIndex < 0)
            {
                _selectedIndex = _images.Count() - 1;
            }
        }

        // Filtering
        public void SortImages(String filter, Boolean isAsc)
        {
            _sorter.IsAsc = isAsc;
            _images = _sorter.Sort(_images, filter);
        }
        public void FilterImages(IEnumerable<String> filterTitles)
        {
            ICollection<IEnumerable<Int32>> rawImagesIds = new List<IEnumerable<Int32>>();
            foreach (String filterTitle in filterTitles)
            {
                rawImagesIds.Add(_imageLabelQuery.FindImagesByFilterId(
                    _labelHandler.FindLabelByTitle(filterTitle)));
            }

            IEnumerable<Int32> filteredImagesIds = rawImagesIds
                .SelectMany(coll => coll
                    .Select(id => id));

            _images = _desktopImageHandler.GetAllImages()
                .Where(img => filteredImagesIds
                .Any(id => id == img.ImageId));
        }

        private Boolean CheckIndexCorrectness()
        {
            return _images.Count() != 0 &&
                _selectedIndex >= 0 && _selectedIndex < _images.Count();

        }

        public Int32 _selectedIndex;
        private IEnumerable<DesktopImage> _images;

        private DesktopImageQuery _desktopImageHandler = new DesktopImageQuery();
        private AccountQuery _accountQuery = new AccountQuery();
        private UserDesktopImageQuery _udiHandler = new UserDesktopImageQuery();
        private LabelQuery _labelHandler = new LabelQuery();
        private DesktopImageLabelQuery _imageLabelQuery = new DesktopImageLabelQuery();
        private AuthorQuery _authorHandler = new AuthorQuery();
        private ImagesSorter _sorter = new ImagesSorter();
    }
}
