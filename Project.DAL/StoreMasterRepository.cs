using Project.BAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL
{
    public class StoreMasterRepository : IStoreMasterRepository, IDisposable
    {
        private DataBaseContext context;
        internal DbSet<StoreMaster> dbSet;

        public StoreMasterRepository(DataBaseContext context)
        {
            this.context = context;            
            this.dbSet = context.Set<StoreMaster>();
        }

        public int RegisterStore(StoreMaster objStoreMaster)
        {
            dbSet.Add(objStoreMaster);
            return context.SaveChanges();
        }

        public int UpdateStoreMaster(StoreMaster objStoreMaster)
        {
            try
            {
                dbSet.Attach(objStoreMaster);
                context.Entry(objStoreMaster).State = EntityState.Modified;
                return context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                return 0;
            }            
        }

        public StoreMaster GetStoreDetailById(int StorerId)
        {
            return dbSet.Find(StorerId);
        }


        public List<StoreMaster> GetAllStoreByOwnerId(int OwnerId)
        {
            IQueryable<StoreMaster> query = dbSet.Where(m=>m.OwnerId == OwnerId);
            return query.ToList();
        }

        public List<StoreMaster> GetAllStoreMaster()
        {
            IQueryable<StoreMaster> query = dbSet;
            return query.ToList();
        }

        public void Dispose()
        {
            this.context.Dispose();
            //throw new NotImplementedException();
        }
    }
}
