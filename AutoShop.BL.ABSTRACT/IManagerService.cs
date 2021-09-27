using AutoShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoShop.BL.IMPL
{
    public interface IManagerService
    {
        void AddObject(ManagerDTO managers);
        ManagerDTO GetElementById(int id);
        IEnumerable<ManagerDTO> GetAllObjects();
        void UpdateObject(ManagerDTO managers);
        void DeleteObject(int id);
    }
}
