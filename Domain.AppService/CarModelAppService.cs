using Domain.Core._01_Entities;
using Domain.Core._02_Contracts.AppServices;
using Domain.Core._02_Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AppService
{
    public class CarModelAppService : ICarModelAppService
    {
        private readonly ICarModelService _service;

        public CarModelAppService(ICarModelService service)
        {
            _service = service;
        }

        public async Task< CarModel> GetCar(int id)
        {
            return await _service.GetById(id);
        }

        public async Task< IEnumerable<CarModel>> GetCars()
        {
            return await _service.GetAll();
        }

        public async Task AddCar(CarModel car)
        {
            await _service.Add(car.Name, car.Manufacturer);
        }

        public async Task EditCar(CarModel car)
        {
             await _service.Update(car);
        }

        public async Task DeleteCar(int id)
        {
           await _service.Delete(id);
        }
    }
}
