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

        public CarModel GetCar(int id)
        {
            return _service.GetById(id);
        }

        public IEnumerable<CarModel> GetCars()
        {
            return _service.GetAll();
        }

        public void AddCar(CarModel car)
        {
            _service.Add(car.Name, car.Manufacturer);
        }

        public void EditCar(CarModel car)
        {
            _service.Update(car);
        }

        public void DeleteCar(int id)
        {
            _service.Delete(id);
        }
    }
}
