using Domain.Core._01_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core._02_Contracts.Repositories
{
    public interface ICarModelRepository
    {
        public Task Add(CarModel carmodel);
        public Task<bool> Delete(int id);
        public Task<bool> Update(CarModel carmodel);
        public Task<CarModel> GetById(int id);
        public Task<IEnumerable<CarModel>> GetAll();
    }
}
