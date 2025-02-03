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
        public async Task Add(string name, string manufacturer)
        {
            CarModel carmodel = new CarModel()
            {
                Name = name,
                Manufacturer = manufacturer
            };
             await _carModelRepository.Add(carmodel);
        }

        public async Task Delete(int id)
        {
            await _carModelRepository.Delete(id);
        }

        public async Task< IEnumerable<CarModel>> GetAll()
        {
            return await _carModelRepository.GetAll();
        }

        public async Task< CarModel> GetById(int id)
        {
            return await _carModelRepository.GetById(id);
        }

        public async Task Update(CarModel carmodel)
        {
           await _carModelRepository.Update(carmodel);
        }
    }
}
