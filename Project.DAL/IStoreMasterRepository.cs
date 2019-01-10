using Project.BAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL
{
   public interface IStoreMasterRepository
    {
       int RegisterStore(StoreMaster objStoreMaster);

        int UpdateStoreMaster(StoreMaster objStoreMasterUsers);

        StoreMaster GetStoreDetailById(int StoreId);

        List<StoreMaster> GetAllStoreByOwnerId(int OwnerId);
        List<StoreMaster> GetAllStoreMaster();
    }
}
