using AutoShop.DAL.ABSTRACT;
using AutoShop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoShop.DAL.IMPL
{
    public class ClientRepository: GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(AutoShopContext contextOptions) : base(contextOptions) { }
    }
}
