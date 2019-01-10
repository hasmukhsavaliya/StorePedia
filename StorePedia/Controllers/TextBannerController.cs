using Project.BAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StorePedia.Controllers
{
    public class TextBannerController : BaseController
    {
        [HttpPost]
        public dynamic InsertTextBanner(TextBanner TextBanner)
        {
            Dictionary<string, dynamic> dicto = new Dictionary<string, dynamic>();
            int id = textBannerRepository.InsertTextBanner(TextBanner);
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
        public dynamic UpdateTextBanner(TextBanner TextBanner)
        {
            Dictionary<string, dynamic> dicto = new Dictionary<string, dynamic>();
            int id = textBannerRepository.UpdateTextBanner(TextBanner);
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
        public dynamic GetBannerDetailById(TextBanner TextBanner)
        {
            Dictionary<string, dynamic> dicto = new Dictionary<string, dynamic>();
            TextBanner objTextBanner = textBannerRepository.GetBannerDetailById(TextBanner.BannerId);
            if (objTextBanner != null)
            {
                return Request.CreateResponse<TextBanner>(HttpStatusCode.OK, objTextBanner);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Error occured");
            }
        }
    

    }
}
