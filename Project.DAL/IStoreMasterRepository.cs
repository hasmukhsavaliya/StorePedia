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
        void InsertStoreMaster(StoreMaster objStoreMaster);

        void UpdateStoreMaster(StoreMaster objStoreMasterUsers);

        StoreMaster GetStoreMasterDetailById(int StoreId);

        List<StoreMaster> GetAllStoreMaster();
    }
}
