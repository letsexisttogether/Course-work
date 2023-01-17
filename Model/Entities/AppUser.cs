using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace Model.Entities
{
    [Table]
    public class AppUser
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public Int32 UserId { get; set; }

        [Column]
        public Int32 AccountId { get; set; }

        [Column(CanBeNull = true)]
        public String UserName { get; set; }

        [Column(CanBeNull = true)]
        public String UserSurname { get; set; }

        [Column(CanBeNull = true)]
        public DateTime UserBirthDate { get; set; }
    }
}
