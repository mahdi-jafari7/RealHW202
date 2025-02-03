using Domain.Core._01_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core._02_Contracts.Services
{
    public interface ICarModelService
    {

        public Task Add(string name, string manufacturer);

        public Task Delete(int id);
        public Task<IEnumerable<CarModel>> GetAll();
        public Task<CarModel> GetById(int id);
        public Task Update(CarModel carmodel);
    }
}
