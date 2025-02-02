using Domain.Core._01_Entities;
using Domain.Core._02_Contracts.Repositories;
using Infra.db.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.db.DataAccess.Repositories
{
    public class CarInspectRepository : ICarInspectRepository
    {
        private readonly InspectionDbContext _db;

        public CarInspectRepository(InspectionDbContext db)
        {
            _db = db;
        }

        public void Add(CarInspection carInspection)
        {
            _db.Add(carInspection);
            _db.SaveChanges();

        }

        public CarInspection GetById(int id)
        {
            return _db.Inspecions.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<CarInspection> GetAll()
        {
            return _db.Inspecions.ToList();
        }

        public void Update(CarInspection carInspection)
        {
            var existing = _db.Inspecions.FirstOrDefault(c => c.Id == carInspection.Id);
            if (existing != null)
            {
                existing.RequestDate = carInspection.RequestDate;
                existing.PlateNumber = carInspection.PlateNumber;
                existing.OwnerNationalId = carInspection.OwnerNationalId;
                existing.CarModel = carInspection.CarModel;
                existing.ProductionYear = carInspection.ProductionYear;
                existing.OwnerPhoneNumber = carInspection.OwnerPhoneNumber;
                existing.OwnerAdress = carInspection.OwnerAdress;
                existing.Status = carInspection.Status;
            }
        }

        public void Delete(int id)
        {
            var carInspection = _db.Inspecions.FirstOrDefault(c => c.Id == id);
            if (carInspection != null)
            {
                _db.Remove(carInspection);
            }
        }

        public void SetConfirm(int id)
        {
            _db.Inspecions.FirstOrDefault(c => c.Id == id).Status = InspectStatusEnum.Confirm;
            _db.SaveChanges();

        }

        public void SetCancell(int id)
        {
            _db.Inspecions.FirstOrDefault(c => c.Id == id).Status = InspectStatusEnum.Cancel;
            _db.SaveChanges();


        }
    }
}