using Project.BAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StorePedia.Controllers
{
    public class StoreController : BaseController
    {
        [HttpPost]
        public dynamic RegisterStoreOwner(StoreMaster StoreMaster)
        {
            Dictionary<string, dynamic> dicto = new Dictionary<string, dynamic>();
            StoreOwner objStoreOwner = new StoreOwner();
            storeMasterRepository.InsertStoreMaster(StoreMaster);
            return "1";
        } 

        [HttpPost]
        public dynamic UpdateStoreOwner(StoreMaster StoreMaster)
        {
            Dictionary<string, dynamic> dicto = new Dictionary<string, dynamic>();
            storeMasterRepository.UpdateStoreMaster(StoreMaster);
            return "1";
        }

    }
}
