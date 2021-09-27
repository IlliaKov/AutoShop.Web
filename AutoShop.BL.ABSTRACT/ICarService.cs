using AutoShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoShop.BL.IMPL
{
    public interface ICarService
    {
        void AddObject(CarDTO cars);
        void DeleteObject(int id);
        IEnumerable<CarDTO> GetAll();
        CarDTO GetElementById(int id);
        void UpdateObject(CarDTO clients);
    }
}
