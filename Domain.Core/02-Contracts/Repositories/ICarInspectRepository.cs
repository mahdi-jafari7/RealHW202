using Domain.Core._01_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core._02_Contracts.Repositories
{
    public interface ICarInspectRepository
    {
        public Task Add(CarInspection carInspection);
        public Task<CarInspection> GetById(int id);
        public Task<IEnumerable<CarInspection>> GetAll();

        public Task Update(CarInspection carInspection);

        public Task Delete(int id);
        public Task SetConfirm(int id);
        public Task SetCancell(int id);


    }
}
