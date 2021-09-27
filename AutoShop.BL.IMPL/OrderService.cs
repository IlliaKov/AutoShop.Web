using AutoShop.DAL.ABSTRACT;
using AutoShop.Entities;
using AutoShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoShop.BL.IMPL
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        //constructor
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void AddObject(OrderDTO orders)
        {
            Order dbEntity = new Order()
            {
               OrderDate = orders.OrderDate,
               OrderNumber = orders.OrderNumber
            };

            _orderRepository.Add(dbEntity);
            _orderRepository.Save();
        }

        public void DeleteObject(int id)
        {
            _orderRepository.Delete(id);
        }

        public IEnumerable<OrderDTO> GetAll()
        {
            return _orderRepository
                .GetAll()
                .Select(p => new OrderDTO()
                {
                    OrderID = p.OrderID,
                    OrderDate = p.OrderDate,
                    OrderNumber = p.OrderNumber
                }
                );
        }

        public OrderDTO GetElementById(int id)
        {
            Order fromDb = _orderRepository.GetById(id);

            OrderDTO orderDTO = new OrderDTO()
            {
                OrderID = fromDb.OrderID,
                OrderDate = fromDb.OrderDate,
                OrderNumber = fromDb.OrderNumber
            };
            return orderDTO;
        }

        public void UpdateObject(OrderDTO orders)
        {
            Order orderBase = new Order()
            {
                OrderID = orders.OrderID,
                OrderDate = orders.OrderDate,
                OrderNumber = orders.OrderNumber
            };
            _orderRepository.Update(orderBase);
        }
    }
}
