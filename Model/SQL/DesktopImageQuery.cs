using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using Model.Entities;
using System.Drawing;

namespace Model.SQL
{
    public class DesktopImageQuery : EntityQuery<DesktopImage>
    {
        // Add
        public void AddImage(DesktopImage image)
        {
            UpdateTable();

            _table.InsertOnSubmit(image);
            _context.SubmitChanges();
        }
        public void AddImageLabelConnection(Int32 imageId, IEnumerable<Int32> labelIds)
        {
            UpdateTable();

            Table<DesktopImageLabel> imageLabelConnection = _context.GetTable<DesktopImageLabel>();
            
            ICollection<DesktopImageLabel> desktopImageLabels = new List<DesktopImageLabel>();

            foreach (Int32 labelId in labelIds)
            {
                desktopImageLabels.Add(new DesktopImageLabel()
                {
                    DesktopImageId = imageId,
                    LabelId = labelId
                });
            }

            imageLabelConnection.InsertAllOnSubmit(desktopImageLabels);
            _context.SubmitChanges();
        }

        // Delete
        public void DeleteImage(DesktopImage image)
        {
            UpdateTable();

            _table.DeleteOnSubmit(image);
            _context.SubmitChanges();
        }

        // Get
        public override DesktopImage GetEntityById(int id)
        {
            UpdateTable();

            return _table.Where(img => img.ImageId == id).FirstOrDefault();
        }
        public IEnumerable<DesktopImage> GetAllImages()
        {
            UpdateTable();

            return _table;
        }
        public IEnumerable<DesktopImage> GetImagesByAuthorId(Int32 id)
        {
            UpdateTable();

            return _table.Where(img => img.AuthorId == id);
        }
        public IEnumerable<DesktopImage> GetImagesByFilterId(Int32 labelId)
        {
            UpdateTable();
            Table<DesktopImageLabel> imageLabelConnection = _context.GetTable<DesktopImageLabel>();

            return from iml in imageLabelConnection
                   where iml.LabelId == labelId
                   join img in _table
                   on iml.DesktopImageId equals img.ImageId
                   select img;
        }

        // Find
        public Int32 FindImageByTitle(String title)
        {
            UpdateTable();

            Int32 resultId;
            try
            {
                resultId = _table
                   .Where(img => img.ImageTitle == title)
                   .Select(img => img.ImageId).Single();
            }
            catch
            {
                resultId = -1;
            }

            return resultId;
        }
        public Int32 FindImageByData(byte[] data)
        {
            UpdateTable();

            Int32 resultId;
            try
            {
                resultId = _table
                   .Where(img => img.MainImage == data)
                   .Select(img => img.ImageId).Single();
            }
            catch
            {
                resultId = -1;
            }

            return resultId;
        }
    }
}
