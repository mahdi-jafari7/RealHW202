using Domain.Core._01_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core._02_Contracts.Services
{
    public interface ICarInspectService
    {
        Task Add(CarInspection carInspection);
        Task<CarInspection> GetById(int id);
        Task<IEnumerable<CarInspection>> GetAll();
        Task Update(CarInspection carInspection);
        Task Delete(int id);
        public Task SetConfirm(int id);
        public Task SetCancell(int id);
    }
}
