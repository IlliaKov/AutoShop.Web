using AutoShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoShop.BL.IMPL
{
    public interface IOrderService
    {
        void AddObject(OrderDTO orders);
        void DeleteObject(int id);
        IEnumerable<OrderDTO> GetAll();
        OrderDTO GetElementById(int id);
        void UpdateObject(OrderDTO orders);
    }
}
