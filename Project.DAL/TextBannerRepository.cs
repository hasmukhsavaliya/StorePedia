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
    public class TextBannerRepository : ITextBannerRepository, IDisposable
    {
        private DataBaseContext context;
        internal DbSet<TextBanner> dbSet;

        public TextBannerRepository(DataBaseContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TextBanner>();
        }

        public int InsertTextBanner(TextBanner objTextBanner)
        {
            dbSet.Add(objTextBanner);
            return context.SaveChanges();
        }

        public int UpdateTextBanner(TextBanner objTextBanner)
        {
            try
            {
                dbSet.Attach(objTextBanner);
                context.Entry(objTextBanner).State = EntityState.Modified;
                return context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                return 0;
            }
        }

        public TextBanner GetBannerDetailById(int BannerId)
        {
            return dbSet.Find(BannerId);
        }


        public List<TextBanner> GetAllTextBanner()
        {
            IQueryable<TextBanner> query = dbSet;
            return query.ToList();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
