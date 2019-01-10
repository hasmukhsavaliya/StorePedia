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
        [HttpGet]
        public string StoreTestAPI()
        {
            return "Hello You have successfully called the Store Test API !! :)";
        }

        [HttpPost]
        public dynamic RegisterStore(StoreMaster StoreMaster)
        {
            Dictionary<string, dynamic> dicto = new Dictionary<string, dynamic>();
            int id = storeMasterRepository.RegisterStore(StoreMaster);
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
        public dynamic UpdateStore(StoreMaster StoreMaster)
        {
            Dictionary<string, dynamic> dicto = new Dictionary<string, dynamic>();
            int id = storeMasterRepository.UpdateStoreMaster(StoreMaster);
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
        public dynamic GetStoreDetailById(StoreMaster StoreMaster)
        {
            Dictionary<string, dynamic> dicto = new Dictionary<string, dynamic>();
            StoreMaster objStoreMaster = storeMasterRepository.GetStoreDetailById(StoreMaster.StoreId);
            if (objStoreMaster != null)
            {
                return Request.CreateResponse<StoreMaster>(HttpStatusCode.OK, objStoreMaster);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Error occured");
            }
        }
        [HttpPost]
        public dynamic GetAllStoreByOwnerId(StoreMaster StoreMaster)
        {
            Dictionary<string, dynamic> dicto = new Dictionary<string, dynamic>();
            List<StoreMaster> objStoreList = storeMasterRepository.GetAllStoreByOwnerId(StoreMaster.OwnerId);
            if (objStoreList != null)
            {
                return Request.CreateResponse<List<StoreMaster>>(HttpStatusCode.OK, objStoreList);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Error occured");
            }
        }


    }
}
