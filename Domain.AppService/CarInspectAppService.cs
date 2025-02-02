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
    public class CarInspectAppService : ICarInspectAppService
    {
        private readonly ICarInspectService _service;

        public CarInspectAppService(ICarInspectService service)
        {
            _service = service;
        }

        public void CreateCarInspection(CarInspection carInspection)
        {
            _service.Add(carInspection);
        }

        public CarInspection GetCarInspectionDetails(int id)
        {
            return _service.GetById(id);
        }

        public IEnumerable<CarInspection> GetAllCarInspections()
        {
            return _service.GetAll();
        }

        public void ModifyCarInspection(CarInspection carInspection)
        {
            _service.Update(carInspection);
        }

        public void RemoveCarInspection(int id)
        {
            _service.Delete(id);
        }

        public void SetConfirm(int id)
        {
            _service.SetConfirm(id);
        }
        public void SetCancell(int id)
        {
            _service.SetCancell(id);
        }
    }
}
