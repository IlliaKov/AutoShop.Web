using AutoShop.DAL.ABSTRACT;
using AutoShop.Entities;
using AutoShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoShop.BL.IMPL
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        
        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public void AddObject(CarDTO cars)
        {
            Car dbEntity = new Car()
            {
                Model = cars.Model,
                Color = cars.Color,
                Price = cars.Price,
                CarDocuments = cars.CarDocuments,
                BuildYear = cars.BuildYear,
                IsCarAvailable = cars.IsCarAvailable
            };

            _carRepository.Add(dbEntity);
            _carRepository.Save();
        }

        public void DeleteObject(int id)
        {
            _carRepository.Delete(id);
        }

        public IEnumerable<CarDTO> GetAll()
        {
            return _carRepository
                .GetAll()
                .Select(p => new CarDTO()
                {
                    CarID = p.CarID,
                    Model = p.Model,
                    Color = p.Color,
                    Price = p.Price,
                    CarDocuments = p.CarDocuments,
                    BuildYear = p.BuildYear,
                    IsCarAvailable = p.IsCarAvailable
                }
                );
        }

        public CarDTO GetElementById(int id)
        {
            Car fromDb = _carRepository.GetById(id);

            CarDTO carDTO = new CarDTO()
            {
                CarID = fromDb.CarID,
                Model = fromDb.Model,
                Color = fromDb.Color,
                Price = fromDb.Price,
                CarDocuments = fromDb.CarDocuments,
                BuildYear = fromDb.BuildYear,
                IsCarAvailable = fromDb.IsCarAvailable
            };
            return carDTO;
        }

        public void UpdateObject(CarDTO clients)
        {
            Car carBase = new Car()
            {
                CarID = clients.CarID,
                Model = clients.Model,
                Color = clients.Color,
                Price = clients.Price,
                CarDocuments = clients.CarDocuments,
                BuildYear = clients.BuildYear,
                IsCarAvailable = clients.IsCarAvailable
            };
            _carRepository.Update(carBase);
        }
    }
}
