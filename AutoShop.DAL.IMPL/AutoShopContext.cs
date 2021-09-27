using AutoShop.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoShop.DAL.IMPL
{
    public class AutoShopContext: DbContext
    {
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Client> Clients { get; set; }
        public AutoShopContext(DbContextOptions<AutoShopContext> contextOptions) : base(contextOptions)
        {
        }
    }
}
