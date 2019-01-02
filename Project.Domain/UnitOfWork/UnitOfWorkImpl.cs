using Project.Domain.Repository;
using Project.Domain.RepositoryProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.UnitOfWork
{
    public class UnitOfWorkImpl : IUnitOfWork
    {
        private readonly DataBaseContext _context;
        private readonly IRepositoryProvider _repositoryProvider;

        public UnitOfWorkImpl()
        {
            _context = new DataBaseContext();

            if (_repositoryProvider == null)
            {
                _repositoryProvider = new RepositoryProviderImpl();
            }

            _repositoryProvider.DbContext = _context;
        }

        public IRepositoryBase<Project> ProjectRepository
        {
            get
            {
                return GetGenericRepository<Project>();
            }
        }

        public IMembershipRepository MembershipRepository
        {
            get
            {
                return GetCustomRepository<IMembershipRepository>();
            }
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        private IRepositoryBase<T> GetGenericRepository<T>() where T : class
        {
            return _repositoryProvider.GetGenericRepository<T>();
        }

        private T GetCustomRepository<T>() where T : class
        {
            return _repositoryProvider.GetCustomRepository<T>();
        }
    }
}
