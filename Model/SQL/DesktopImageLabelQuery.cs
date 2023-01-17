using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entities;
using System.Data.Linq;

namespace Model.SQL
{
    public class DesktopImageLabelQuery : EntityQuery<DesktopImageLabel>
    {
        public override DesktopImageLabel GetEntityById(int id)
        {
            UpdateTable();

            return _table
                .Where(dil => dil.DesktopImageMarkId == id)
                .FirstOrDefault();
        }

        public IEnumerable<Int32> FindImagesByFilterId(Int32 labelId)
        {
            UpdateTable();

            return _table.Where(idl => idl.LabelId == labelId).Select(idl => idl.DesktopImageId);
        }
    }
}
