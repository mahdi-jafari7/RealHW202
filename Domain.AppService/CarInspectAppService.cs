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

        public async Task CreateCarInspection(CarInspection carInspection)
        {
             await _service.Add(carInspection);
        }

        public async Task< CarInspection> GetCarInspectionDetails(int id)
        {
            return await _service.GetById(id);
        }

        public async Task<IEnumerable<CarInspection>> GetAllCarInspections()
        {
            return await _service.GetAll();
        }

        public async Task ModifyCarInspection(CarInspection carInspection)
        {
            await _service.Update(carInspection);
        }

        public async Task RemoveCarInspection(int id)
        {
           await _service.Delete(id);
        }

        public async Task SetConfirm(int id)
        {
           await _service.SetConfirm(id);
        }
        public async Task SetCancell(int id)
        {
            await _service.SetCancell(id);
        }
    }
}




