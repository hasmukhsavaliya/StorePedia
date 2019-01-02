using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using Project.Business.Models;
namespace Project.Domain
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext()
            : base("MyConnectionString")
        {

        }

        public DbSet<Pro> Projects { get; set; }
        // Your entities here...
    }
}
