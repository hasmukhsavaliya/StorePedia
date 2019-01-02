using Project.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Helpers
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Project> ProjectRepository { get; }

        IMembershipRepository MembershipRepository { get; }

        int Save();
    }
}
