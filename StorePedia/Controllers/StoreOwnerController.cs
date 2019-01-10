using Project.BAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StorePedia.Controllers
{
    public class StoreOwnerController : BaseController
    {
        [HttpPost]
        public HttpResponseMessage RegisterStoreOwner(StoreOwner StoreOwner)
        {
            Dictionary<string, dynamic> dicto = new Dictionary<string, dynamic>();
            StoreOwner objStoreOwner = new StoreOwner();
            objStoreOwner.OwnerName = StoreOwner.OwnerName;
            objStoreOwner.OwnerPassword = StoreOwner.OwnerPassword;
            objStoreOwner.TermsAndCondition = StoreOwner.TermsAndCondition;
            objStoreOwner.DeviceToken = StoreOwner.DeviceToken;
            objStoreOwner.DeviceType = StoreOwner.DeviceType;
            objStoreOwner.MobileNo = StoreOwner.MobileNo;
            //objStoreOwner.Status = true;
            objStoreOwner.OwnerId = 0;
            objStoreOwner.CreatedOn = DateTime.UtcNow;
            //objStoreOwner.CreatedBy = 1;
            objStoreOwner.OTP = "123456";
            objStoreOwner.OTPFor = 1;
            int id = storeOwnerRepository.InsertStoreOwner(objStoreOwner);

            if (id > 0)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Record Saved");
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Error occured");
            }

        }

        [HttpPost]
        public HttpResponseMessage UpdateStoreOwner(StoreOwner StoreOwner)
        {
            Dictionary<string, dynamic> dicto = new Dictionary<string, dynamic>();
            StoreOwner objStoreOwner = new StoreOwner();
            objStoreOwner.OwnerName = StoreOwner.OwnerName;
            objStoreOwner.OwnerEmailId = StoreOwner.OwnerEmailId;
            objStoreOwner.OwnerPassword = StoreOwner.OwnerPassword;
            objStoreOwner.DeviceToken = StoreOwner.DeviceToken;
            objStoreOwner.DeviceType = StoreOwner.DeviceType;
            objStoreOwner.MobileNo = StoreOwner.MobileNo;
            //objStoreOwner.Status = true;
            objStoreOwner.OwnerId = StoreOwner.OwnerId;
            objStoreOwner.UpdatedOn = DateTime.UtcNow;
            //objStoreOwner.CreatedBy = 1;
            int id = storeOwnerRepository.UpdateStoreOwner(objStoreOwner);
            if (id > 0)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Record updated");
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Error occured");
            }

        }

        [HttpPost]
        public HttpResponseMessage StoreOwnerChangePassword(StoreOwnerChangePassword StoreOwner)
        {
            Dictionary<string, dynamic> dicto = new Dictionary<string, dynamic>();
            StoreOwner objStoreOwner = new StoreOwner();

            objStoreOwner = storeOwnerRepository.StoreOwnerChangePassword(StoreOwner.OwnerId, StoreOwner.OwnerPassword, StoreOwner.NewPassword);
            if (objStoreOwner != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Password changed successfully");
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Error occured");
            }
        }
        [HttpPost]
        public HttpResponseMessage StoreOwnerLogin(StoreOwnerLogin StoreOwner)
        {
            Dictionary<string, dynamic> dicto = new Dictionary<string, dynamic>();
            StoreOwner objStoreOwner = new StoreOwner();
            objStoreOwner = storeOwnerRepository.StoreOwnerLogin(StoreOwner.MobileNo, StoreOwner.OwnerPassword);
            if (objStoreOwner != null)
            {
                return Request.CreateResponse<StoreOwner>(HttpStatusCode.OK, objStoreOwner);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Error occured");
            }
        }

    }
}
