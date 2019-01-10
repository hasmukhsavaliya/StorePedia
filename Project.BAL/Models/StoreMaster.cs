using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BAL.Models
{
     [Table("StoreMaster")]
    public class StoreMaster
    {
        [Key]
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string EmailId { get; set; }
        public string MobileNo { get; set; }
        public string Address { get; set; }
        public string LandMark { get; set; }
        public int Pin { get; set; }
        public string Location { get; set; }
        public string StoreCategory { get; set; }
        public string SubCategory { get; set; }
        public string Business { get; set; }
        public string Policies { get; set; }
        public string PaymentType { get; set; }
        public Nullable<DateTime> CreatedOn { get; set; }
        public Nullable<DateTime> UpdateOn { get; set; }
        public bool Status { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public int OwnerId { get; set; }
         
    }
}
