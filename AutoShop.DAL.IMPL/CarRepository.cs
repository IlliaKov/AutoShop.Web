using AutoShop.DAL.ABSTRACT;
using AutoShop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoShop.DAL.IMPL
{
    public class CarRepository: GenericRepository<Car>, ICarRepository
    {
        public CarRepository(AutoShopContext contextOptions) : base(contextOptions) { }
    }
}
