using Project.BAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL
{
    public interface IStoreOwnerRepository:IDisposable
    {
        void InsertStoreOwner(StoreOwner objStoreOwner);

        void UpdateStoreOwner(StoreOwner objStoreOwnerUsers);

        StoreOwner StoreOwnerLogin(string MobileNo, string Password);

        StoreOwner StoreOwnerChangePassword(int OwnerId, string OwnerPassword, string NewPassword);

        StoreOwner GetStoreOwnerDetailById(int UserId);

        List<StoreOwner> GetAllStoreOwner();
    }
}
