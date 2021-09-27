using AutoShop.DAL.ABSTRACT;
using AutoShop.Entities;
using AutoShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoShop.BL.IMPL
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        //constructor
        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public void AddObject(ClientDTO clients)
        {
            Client dbEntity = new Client()
            {
                FullName = clients.FullName,
                Gender = clients.Gender,
                Birthday = clients.Birthday,
                PassportData = clients.PassportData,
                HomeAdress = clients.HomeAdress,
                PhoneNumber = clients.PhoneNumber
            };

            _clientRepository.Add(dbEntity);
            _clientRepository.Save();
        }

        public void DeleteObject(int id)
        {
            _clientRepository.Delete(id);
        }

        public IEnumerable<ClientDTO> GetAll()
        {
            return _clientRepository
                .GetAll()
                .Select(p => new ClientDTO()
                {
                    ClientID = p.ClientID,
                    FullName = p.FullName,
                    Gender = p.Gender,
                    Birthday = p.Birthday,
                    PassportData = p.PassportData,
                    HomeAdress = p.HomeAdress,
                    PhoneNumber = p.PhoneNumber
                }
                );
        }

        public ClientDTO GetElementById(int id)
        {
            Client fromDb = _clientRepository.GetById(id);

            ClientDTO clientDTO = new ClientDTO()
            {
                ClientID = fromDb.ClientID,
                FullName = fromDb.FullName,
                Gender = fromDb.Gender,
                Birthday = fromDb.Birthday,
                PassportData = fromDb.PassportData,
                HomeAdress = fromDb.HomeAdress,
                PhoneNumber = fromDb.PhoneNumber
            };
            return clientDTO;
        }

        public void UpdateObject(ClientDTO clients)
        {
            Client clientBase = new Client()
            {
                ClientID = clients.ClientID,
                FullName = clients.FullName,
                Gender = clients.Gender,
                Birthday = clients.Birthday,
                PassportData = clients.PassportData,
                HomeAdress = clients.HomeAdress,
                PhoneNumber = clients.PhoneNumber
            };
            _clientRepository.Update(clientBase);
        }
    }
}
