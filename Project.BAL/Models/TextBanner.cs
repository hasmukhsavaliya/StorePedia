using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BAL.Models
{
    [Table("TextBanner")]
    public class TextBanner
    {
        [Key]
        public int BannerId { get; set; }
        public string BannerName { get; set; }
        public string BannerText { get; set; }
        public Nullable<DateTime> CreatedOn { get; set; }
        public Nullable<DateTime> UpdatedOn { get; set; }
        public Nullable<DateTime> PublishedOn { get; set; }
        public Nullable<DateTime> LastDate { get; set; }
        public bool Status { get; set; }
        public bool IsDeleted { get; set; }
        public int StoreId { get; set; }
        public int OwnerId { get; set; }

    }
}
