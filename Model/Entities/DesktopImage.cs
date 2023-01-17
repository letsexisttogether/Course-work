using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
using System.Drawing;

namespace Model.Entities
{
    [Table]
    public class DesktopImage
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public Int32 ImageId { get; set; }

        [Column]
        public Int32 AuthorId { get; set; }

        [Column]
        public String ImageTitle { get; set; }  

        [Column]
        public byte[] MainImage { get; set; }

        [Column]
        public Int32 ImageWidth { get; set; }

        [Column]
        public Int32 ImageHeigth { get; set; }

        [Column]
        public Int32 ImageSize { get; set; }

        [Column]
        public DateTime ImageAddDate { get; set; }

        [Column]
        public String ImageFormat { get; set; }
    }
}
