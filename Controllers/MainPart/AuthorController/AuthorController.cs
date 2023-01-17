using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Data.Linq;
using System.IO;
using System.Windows.Forms;
using Model.Entities;
using Model.SQL;
using Model.Processors;

namespace Controllers.MainPart
{
    public class AuthorController
    {
        public AuthorController(Int32 id)
        {
            _author = _queueAuthorHandler.GetEntityByAccountId(id);

            ImagesController = new ImagesController();
            AccountController = new AccountController(id);
        }

        // Add
        public AddResult AddNewImage(String title, Image data, Int32 imageSize, 
            Tuple<Int32, Int32> resolution, DateTime addDate, String format,
            IEnumerable<String> filters)
        {
            byte[] image = ImageParser.ImageToBytes(data, format);

            if (_desktopImageHandler.FindImageByTitle(title) != -1
                || _desktopImageHandler.FindImageByData(image) != -1)
            {
                return AddResult.Entity_already_exists;
            }

            _desktopImageHandler.AddImage(new DesktopImage()
            {
                ImageTitle = title,
                AuthorId = _author.AuthorId,
                MainImage = image,
                ImageSize = imageSize,
                ImageWidth = resolution.Item1,
                ImageHeigth = resolution.Item2,
                ImageAddDate = addDate,
                ImageFormat = format
            });

            ICollection<Int32> labelIds = new List<Int32>();
            foreach (String filter in filters)
            {
                labelIds.Add(_labelHandler.FindLabelByTitle(filter));
            }

            _desktopImageHandler.AddImageLabelConnection
                (_desktopImageHandler.FindImageByTitle(title), labelIds);

            SetAuthorRank();

            return AddResult.Success;
        }

        // Get 
        public String GetAuthorRank()
        {
            return _rankHandler.GetEntityById(_author.AuthorRankId)
                .AuthorRankTitle;
        }
        public DesktopImage GetImageFromFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPG|*.jpg|PNG|*.png";
            openFileDialog.ShowDialog();

            String fileName = openFileDialog.FileName;

            if (fileName == String.Empty)
            {
                return null;
            }

            _imageParser = new ImageParser(fileName);

            DesktopImage image = _imageParser.DesktopImage;

            return image;
        }
        public IEnumerable<String> GetLabelNames()
        {
            return _labelHandler.GetAllLabels().Select(lb => lb.LabelTitle);
        }

        // Filtering
        public void MakeImagesSortedAndFiltered(IEnumerable<String> lables, String sortFilter, Boolean isAsc)
        {
            if (lables.Count() != 0)
            {
                ImagesController.FilterImages(lables);
            }
            else
            {
                ImagesController.UpdateImages();
            }

            ImagesController.UpdateImagesByAuthorId(_author.AuthorId);
            ImagesController.SortImages(sortFilter, isAsc);
        }

        private void SetAuthorRank()
        {
            Int32 workdsCount = _desktopImageHandler
                .GetImagesByAuthorId(_author.AuthorId).Count();


            Int32 rankId;
            if (workdsCount < 3)
            {
                rankId = _rankHandler.FindByTitle("Новачок");
            }
            else if (workdsCount < 5)
            {
                rankId = _rankHandler.FindByTitle("Досвідчений");
            }
            else if (workdsCount < 10)
            {
                rankId = _rankHandler.FindByTitle("Володар зображень");
            }
            else
            {
                rankId = _rankHandler.FindByTitle("Легенда світу зображень");
            }

            _author.AuthorRankId = rankId;
            _queueAuthorHandler.UpdateRank(_author.AuthorId, rankId);
        }

        private AuthorQuery _queueAuthorHandler = new AuthorQuery();
        private DesktopImageQuery _desktopImageHandler = new DesktopImageQuery();
        private LabelQuery _labelHandler  = new LabelQuery();
        private AuthorRankQuery _rankHandler = new AuthorRankQuery();

        public ImagesController ImagesController { get; private set; }
        public AccountController AccountController { get; private set; }

        private Author _author;
        private ImageParser _imageParser;
    }
}
