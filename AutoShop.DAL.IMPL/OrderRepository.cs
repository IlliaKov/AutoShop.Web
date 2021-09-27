using AutoShop.DAL.ABSTRACT;
using AutoShop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoShop.DAL.IMPL
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(AutoShopContext contextOptions) : base(contextOptions){}
    }
}
