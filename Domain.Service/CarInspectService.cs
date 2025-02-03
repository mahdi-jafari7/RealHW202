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
    public class CarInspectService : ICarInspectService
    {
        private readonly ICarInspectRepository _repository;

        public CarInspectService(ICarInspectRepository repository)
        {
            _repository = repository;
        }

        public async Task Add(CarInspection carInspection)
        {
            await _repository.Add(carInspection);
        }

        public async Task< CarInspection> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task< IEnumerable<CarInspection>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task Update(CarInspection carInspection)
        {
           await _repository.Update(carInspection);
        }

        public async Task Delete(int id)
        {
            await _repository.Delete(id);
        }

        public async Task SetConfirm(int id)
        {
            await _repository.SetConfirm(id);
        }
        public async Task SetCancell(int id)
        {
            await _repository.SetCancell(id);
        }
    }
}
