using AutoShop.DAL.ABSTRACT;
using AutoShop.Entities;
using AutoShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoShop.BL.IMPL
{
    public class ManagerService : IManagerService
    {
        private readonly IManagerRepository _managerRepository;
        //constructor
        public ManagerService(IManagerRepository managerRepository)
        {
            _managerRepository = managerRepository;
        }

        public void AddObject(ManagerDTO managers)
        {
            Manager dbEntity = new Manager()
            {
                FullName = managers.FullName,
                Gender = managers.Gender,
                Birthday = managers.Birthday,
                PassportData = managers.PassportData,
                HomeAdress = managers.HomeAdress,
                PhoneNumber = managers.PhoneNumber
            };

            _managerRepository.Add(dbEntity);
            _managerRepository.Save();
        }

        public void DeleteObject(int id)
        {
            _managerRepository.Delete(id);
        }

        public IEnumerable<ManagerDTO> GetAllObjects()
        {
            return _managerRepository
                .GetAll()
                .Select(p => new ManagerDTO()
                {
                    ManagerID = p.ManagerID,
                    FullName = p.FullName,
                    Gender = p.Gender,
                    Birthday = p.Birthday,
                    PassportData = p.PassportData,
                    HomeAdress = p.HomeAdress,
                    PhoneNumber = p.PhoneNumber
                }
                );
        }

        public ManagerDTO GetElementById(int id)
        {
            Manager fromDb = _managerRepository.GetById(id);

            ManagerDTO managerDto = new ManagerDTO()
            {
                ManagerID = fromDb.ManagerID,
                FullName = fromDb.FullName,
                Gender = fromDb.Gender,
                Birthday = fromDb.Birthday,
                PassportData = fromDb.PassportData,
                HomeAdress = fromDb.HomeAdress,
                PhoneNumber = fromDb.PhoneNumber
            };
            return managerDto;
        }

        public void UpdateObject(ManagerDTO managers)
        {
            Manager managerBase = new Manager()
            {
                ManagerID = managers.ManagerID,
                FullName = managers.FullName,
                Gender = managers.Gender,
                Birthday = managers.Birthday,
                PassportData = managers.PassportData,
                HomeAdress = managers.HomeAdress,
                PhoneNumber = managers.PhoneNumber
            };
            _managerRepository.Update(managerBase);
        }
    }
}
