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

        Task<CarModel> GetCar(int id);
        Task<IEnumerable<CarModel>> GetCars();
        Task AddCar(CarModel car);
        Task EditCar(CarModel car);
        Task DeleteCar(int id);
    }
}
