using Project.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace StorePedia.Controllers
{
    public class BaseController : ApiController
    {   
        //
        public IStoreOwnerRepository storeOwnerRepository;
        public IStoreMasterRepository storeMasterRepository;
        public ITextBannerRepository textBannerRepository;

        public BaseController()
        {
            this.storeOwnerRepository = new StoreOwnerRepository(new DataBaseContext());
            this.storeMasterRepository = new StoreMasterRepository(new DataBaseContext());
            this.textBannerRepository = new TextBannerRepository(new DataBaseContext());
        }
    }
}