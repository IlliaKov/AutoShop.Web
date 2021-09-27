using AutoShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoShop.BL.IMPL
{
    public interface IClientService
    {
        void AddObject(ClientDTO clients);
        void DeleteObject(int id);
        IEnumerable<ClientDTO> GetAll();
        ClientDTO GetElementById(int id);
        void UpdateObject(ClientDTO clients);
    }
}
