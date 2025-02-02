using Domain.Core._01_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core._02_Contracts.AppServices
{
    public interface ICarModelAppService
    {

        CarModel GetCar(int id);
        IEnumerable<CarModel> GetCars();
        void AddCar(CarModel car);
        void EditCar(CarModel car);
        void DeleteCar(int id);
    }
}
