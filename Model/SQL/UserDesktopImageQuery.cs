using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entities;

namespace Model.SQL
{
    public class UserDesktopImageQuery : EntityQuery<UserDesktopImage>
    {
        // Add
        public void AddUserDesktopImage(UserDesktopImage connection)
        {
            UpdateTable();

            _table.InsertOnSubmit(connection);
            _context.SubmitChanges();
        }

        public void UpdateRating(Int32 userId, Int32 imageId, Int32 rating)
        {
            UpdateTable();

            UserDesktopImage currentUdi = 
                _table.Where(udi => udi.UserId == userId 
                && udi.DesktopImageId == imageId).FirstOrDefault();

            currentUdi.Rating = rating;
            _context.SubmitChanges();
        }

        public void DeleteUserDesktopImage(UserDesktopImage connection)
        {
            UpdateTable();

            _table.DeleteOnSubmit(connection);
            _context.SubmitChanges();
        }

        // Get
        public override UserDesktopImage GetEntityById(Int32 id)
        {
            UpdateTable();

            return _table
                .Where(udi => udi.UserDesktopImageId == id)
                .FirstOrDefault();
        }
        public Double GetDesktopImageAvgRating(Int32 id)
        {
            UpdateTable();

            try
            {
                return _table
                    .Where(udi => udi.DesktopImageId == id && udi.Rating != 0)
                    .Average(udi => udi.Rating);
            }
            catch
            {
                return 0.0;
            }
        }

        // Find
        public Int32 FindUserDesktopImageById(Int32 userId, Int32 imageId)
        {
            UpdateTable();

            try
            {
                return _table
                    .Where(udi => udi.UserId == userId && udi.DesktopImageId == imageId)
                    .Select(udi => udi.UserDesktopImageId)
                    .Single();
            }
            catch
            {
                return -1;
            }
        }
    }
}
