using Project.BAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext()
            : base("StorePedia") 
        {

        }
        public DbSet<StoreOwner> StoreOwner { get; set; }
        public DbSet<StoreMaster> StoreMaster { get; set; }
        public DbSet<TextBanner> TextBanner { get; set; }
    }
}
