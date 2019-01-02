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
        public dynamic RegisterStoreOwner(StoreOwner StoreOwner)
        {
            Dictionary<string, dynamic> dicto = new Dictionary<string, dynamic>();
            StoreOwner objStoreOwner = new StoreOwner();
            objStoreOwner.OwnerName = StoreOwner.OwnerName;
            objStoreOwner.OwnerPassword = StoreOwner.OwnerPassword;
            objStoreOwner.TermsAndCondition = StoreOwner.TermsAndCondition;
            objStoreOwner.DeviceToken = StoreOwner.DeviceToken;
            objStoreOwner.DeviceType = StoreOwner.DeviceType;
            //objStoreOwner.Status = true;
            objStoreOwner.OwnerId = 0;
            objStoreOwner.CreatedOn = DateTime.Now;
            //objStoreOwner.CreatedBy = 1;
            storeOwnerRepository.InsertStoreOwner(objStoreOwner);
            return "1";
        }

        [HttpPost]
        public dynamic UpdateStoreOwner(StoreOwner StoreOwner)
        {
            Dictionary<string, dynamic> dicto = new Dictionary<string, dynamic>();
            StoreOwner objStoreOwner = new StoreOwner();
            objStoreOwner.OwnerName = StoreOwner.OwnerName;
            objStoreOwner.OwnerEmailId = StoreOwner.OwnerEmailId;
            objStoreOwner.DeviceToken = StoreOwner.DeviceToken;
            objStoreOwner.DeviceType = StoreOwner.DeviceType;
            //objStoreOwner.Status = true;
            objStoreOwner.OwnerId = StoreOwner.OwnerId;
            objStoreOwner.UpdatedOn = DateTime.Now;
            //objStoreOwner.CreatedBy = 1;
            storeOwnerRepository.UpdateStoreOwner(objStoreOwner);
            return "1";
        }

        [HttpPost]
        public dynamic StoreOwnerChangePassword(StoreOwnerChangePassword StoreOwner)
        {
            Dictionary<string, dynamic> dicto = new Dictionary<string, dynamic>();
            StoreOwner objStoreOwner = new StoreOwner();
            storeOwnerRepository.StoreOwnerChangePassword(StoreOwner.OwnerId, StoreOwner.OwnerPassword, StoreOwner.NewPassword);
            return "1";
        }
        [HttpPost]
        public dynamic StoreOwnerLogin(StoreOwnerLogin StoreOwner)
        {
            Dictionary<string, dynamic> dicto = new Dictionary<string, dynamic>();
            StoreOwner objStoreOwner = new StoreOwner();
            storeOwnerRepository.StoreOwnerLogin(StoreOwner.MobileNo, StoreOwner.OwnerPassword);
            return "1";
        }
    }
}
