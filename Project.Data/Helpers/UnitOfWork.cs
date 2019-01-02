using Project.Data.Repository;
using Project.Domain;
using Project.Domain.Helpers;
using Project.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Helpers
{
    public class UnitOfWork : IUnitOfWork, System.IDisposable
    {
        
        private readonly DataBaseContext _context;
        private readonly IRepositoryProvider _repositoryProvider;

        public UnitOfWork()
        {
            _context = new DataBaseContext();

            if (_repositoryProvider == null)
            {
                _repositoryProvider = new RepositoryProviderImpl();
            }

            _repositoryProvider.DbContext = _context;
        }

        //public IRepositoryBase<Project> ProjectRepository
        //{
        //    get
        //    {
        //        return GetGenericRepository<Project>();
        //    }
        //}

        //public IMembershipRepository MembershipRepository
        //{
        //    get
        //    {
        //        return GetCustomRepository<IMembershipRepository>();
        //    }
        //}

        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        private IRepository<T> GetGenericRepository<T>() where T : class
        {
            return _repositoryProvider.GetGenericRepository<T>();
        }

        private T GetCustomRepository<T>() where T : class
        {
            return _repositoryProvider.GetCustomRepository<T>();
        }
    }
}
