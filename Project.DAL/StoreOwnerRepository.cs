using Project.BAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL
{
    public class StoreOwnerRepository: IStoreOwnerRepository, IDisposable
    {
        private DataBaseContext context;
        internal DbSet<StoreOwner> dbSet;

        public StoreOwnerRepository(DataBaseContext context)
        {
            this.context = context;
            this.dbSet = context.Set<StoreOwner>();
        }

        public void InsertStoreOwner(StoreOwner objStoreOwner)
        {
            dbSet.Add(objStoreOwner);
            context.SaveChanges();
        }

        public void UpdateStoreOwner(StoreOwner objStoreOwner)
        {
            try
            {
                dbSet.Attach(objStoreOwner);
                context.Entry(objStoreOwner).State = EntityState.Modified;
                context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {

            }            
        }

        public StoreOwner StoreOwnerLogin(string MobileNo, string OwnerPassword)
        {
            return context.Database.SqlQuery<StoreOwner>("EXEC so_StoreOwner_Login @MobileNo,@OwnerPassword",
                                                    new SqlParameter("@MobileNo", MobileNo),
                                                    new SqlParameter("@OwnerPassword", OwnerPassword)).SingleOrDefault();
        }
        public StoreOwner StoreOwnerChangePassword(int OwnerId, string OwnerPassword, string NewPassword)
        {
            return context.Database.SqlQuery<StoreOwner>("EXEC so_StoreOwner_Login @OwnerId,@OwnerPassword,",
                                                    new SqlParameter("@OwnerId", OwnerId),
                                                    new SqlParameter("@OwnerPassword", OwnerPassword),
                                                    new SqlParameter("@NewPassword", NewPassword)).SingleOrDefault();
        }

        public StoreOwner GetStoreOwnerDetailById(int OwnerId)
        {
            return dbSet.Find(OwnerId);
        }

        public List<StoreOwner> GetAllStoreOwner()
        {
            IQueryable<StoreOwner> query = dbSet;
            return query.ToList();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
