using Domain.Core._01_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core._02_Contracts.AppServices
{
    public interface ICarInspectAppService
    {
        public Task CreateCarInspection(CarInspection carInspection);
        public Task<CarInspection> GetCarInspectionDetails(int id);
        public Task<IEnumerable<CarInspection>> GetAllCarInspections();
        public Task ModifyCarInspection(CarInspection carInspection);
        public Task RemoveCarInspection(int id);
        public Task SetConfirm(int id);
        public Task SetCancell(int id);

    }
}
