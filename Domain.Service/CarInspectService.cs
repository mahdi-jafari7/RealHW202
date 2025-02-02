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

        public void Add(CarInspection carInspection)
        {
            _repository.Add(carInspection);
        }

        public CarInspection GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<CarInspection> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(CarInspection carInspection)
        {
            _repository.Update(carInspection);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public void SetConfirm(int id)
        {
            _repository.SetConfirm(id);
        }
        public void SetCancell(int id)
        {
            _repository.SetCancell(id);
        }
    }
}
