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
        void Add(CarInspection carInspection);
        CarInspection GetById(int id);
        IEnumerable<CarInspection> GetAll();
        void Update(CarInspection carInspection);
        void Delete(int id);
        public void SetConfirm(int id);
        public void SetCancell(int id);

    }
}
