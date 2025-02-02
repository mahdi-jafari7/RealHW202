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
        void CreateCarInspection(CarInspection carInspection);
        CarInspection GetCarInspectionDetails(int id);
        IEnumerable<CarInspection> GetAllCarInspections();
        void ModifyCarInspection(CarInspection carInspection);
        void RemoveCarInspection(int id);
        public void SetConfirm(int id);
        public void SetCancell(int id);

    }
}
