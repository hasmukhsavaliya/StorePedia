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
    public class StoreMasterRepository : IStoreMasterRepository
    {
        private DataBaseContext context;
        internal DbSet<StoreMaster> dbSet;

        public StoreMasterRepository(DataBaseContext context)
        {
            this.context = context;
            this.dbSet = context.Set<StoreMaster>();
        }

        public void InsertStoreMaster(StoreMaster objStoreMaster)
        {
            dbSet.Add(objStoreMaster);
            context.SaveChanges();
        }

        public void UpdateStoreMaster(StoreMaster objStoreMaster)
        {
            try
            {
                dbSet.Attach(objStoreMaster);
                context.Entry(objStoreMaster).State = EntityState.Modified;
                context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {

            }            
        }

        public StoreMaster GetStoreMasterDetailById(int OwnerId)
        {
            return dbSet.Find(OwnerId);
        }

        public List<StoreMaster> GetAllStoreMaster()
        {
            IQueryable<StoreMaster> query = dbSet;
            return query.ToList();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
