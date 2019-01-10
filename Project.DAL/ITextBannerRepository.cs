using Project.BAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL
{
   public interface ITextBannerRepository
    {
       int InsertTextBanner(TextBanner objTextBanner);

        int UpdateTextBanner(TextBanner objTextBanner);

        TextBanner GetBannerDetailById(int BannerId);

        List<TextBanner> GetAllTextBanner();
    }
}
