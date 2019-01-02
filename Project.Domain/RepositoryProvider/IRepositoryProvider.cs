using Project.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.RepositoryProvider
{
    internal interface IRepositoryProvider
    {
        DataBaseContext DbContext { get; set; }

        IRepositoryBase<T> GetGenericRepository<T>() where T : class;

        T GetCustomRepository<T>(Func<DataBaseContext, object> factory = null) where T : class;
    }
}
