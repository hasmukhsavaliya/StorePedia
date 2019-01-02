using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BAL.Models
{
    [Table("StoreOwner")]
    public class StoreOwner
    {
        [Key]
        public int OwnerId { get; set; }
        public string OwnerName { get; set; }
        public string OwnerEmailId { get; set; }
        public string MobileNo { get; set; }
        public string OwnerPassword { get; set; }
        public bool TermsAndCondition { get; set; }
        public string OTP { get; set; }
        public int DefaultLanguage { get; set; }
        public string DeviceToken { get; set; }
        public Nullable<DateTime> CreatedOn { get; set; }
        public bool IsDeleted { get; set; }
        public int DeviceType { get; set; }
        public Nullable<DateTime> UpdatedOn { get; set; }
        public bool OTPVerified { get; set; }
        public int OTPFor { get; set; }
    }


    public class StoreOwnerSignUpEdit
    {
        public string OwnerName { get; set; }
        public string OwnerEmailId { get; set; }
        public string MobileNo { get; set; }
        public string OwnerPassword { get; set; }
        public string ConfirmPassword { get; set; }
        public bool TermsAndCondition { get; set; }
        public int DefaultLanguage { get; set; }
        public string DeviceToken { get; set; }
        public Nullable<DateTime> CreatedOn { get; set; }
        public int DeviceType { get; set; }
        public bool OTPVerified { get; set; }
        public int OTPFor { get; set; }

    }

    public class StoreOwnerLogin
    {

        public string MobileNo { get; set; }
        public string OwnerPassword { get; set; }
    }
    public class StoreOwnerVerifyOTP
    {
        public int OwnerId { get; set; }
        public string MobileNo { get; set; }
        public string OTP { get; set; }
        public int OTPFor { get; set; }
        public bool OTPVerified { get; set; }
    }

    public class StoreOwnerChangePassword
    {
        public int OwnerId { get; set; }
        public string MobileNo { get; set; }
        public string OwnerPassword { get; set; }
        public string NewPassword { get; set; }
    }

    public class StoreOwnerForgotPassword
    {
        public int OwnerId { get; set; }
        public string MobileNo { get; set; }
        public string OwnerPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
