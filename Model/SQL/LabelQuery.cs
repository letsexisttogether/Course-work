using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entities;

namespace Model.SQL
{
    public class LabelQuery : EntityQuery<Label>
    {
        // Get
        public override Label GetEntityById(int id)
        {
            UpdateTable();

            Label label;
            try
            {
                label = _table.Where(lb => lb.LabelId == id).Single();
            }
            catch
            {
                label = null;
            }

            return label;
        }
        public IEnumerable<Label> GetAllLabels()
        {
            UpdateTable();

            return _table.ToList();
        }
        public IEnumerable<String> GetAllLabelsTitles()
        {
            UpdateTable();

            return _table.Select(lbl => lbl.LabelTitle);
        }

        // Find
        public Int32 FindLabelByTitle(String title)
        {
            UpdateTable();

            foreach (Label label in _table)
            {
                if (label.LabelTitle == title)
                {
                    return label.LabelId;
                }
            }

            return -1;
        }
    }
}
