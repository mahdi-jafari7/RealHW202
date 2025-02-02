using Domain.Core._01_Entities;
using Domain.Core._02_Contracts.Repositories;
using Domain.Core._02_Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class CarModelService : ICarModelService
    {

        private readonly ICarModelRepository _carModelRepository;

        public CarModelService(ICarModelRepository carModelRepository)
        {
            _carModelRepository = carModelRepository;
        }
        public void Add(string name, string manufacturer)
        {
            CarModel carmodel = new CarModel()
            {
                Name = name,
                Manufacturer = manufacturer
            };
            _carModelRepository.Add(carmodel);
        }

        public void Delete(int id)
        {
            _carModelRepository.Delete(id);
        }

        public IEnumerable<CarModel> GetAll()
        {
            return _carModelRepository.GetAll();
        }

        public CarModel GetById(int id)
        {
            return _carModelRepository.GetById(id);
        }

        public void Update(CarModel carmodel)
        {
            _carModelRepository.Update(carmodel);
        }
    }
}
