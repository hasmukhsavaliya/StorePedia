using Project.Business.Models;
using Project.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IRepositoryBase<Pro> ProjectRepository { get; }

        IMembershipRepository MembershipRepository { get; }

        int Save();
    }
}
