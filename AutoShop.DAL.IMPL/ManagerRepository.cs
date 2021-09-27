using AutoShop.DAL.ABSTRACT;
using AutoShop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoShop.DAL.IMPL
{
    public class ManagerRepository: GenericRepository<Manager>, IManagerRepository
    {
        public ManagerRepository(AutoShopContext contextOptions) : base(contextOptions) {}
    }
}
