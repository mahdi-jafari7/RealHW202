using Domain.Core._01_Entities;
using Domain.Core._02_Contracts.Repositories;
using Infra.db.Common;
using Microsoft.EntityFrameworkCore;
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

        public async Task Add(CarInspection carInspection)
        {
            await _db.AddAsync(carInspection);
            _db.SaveChanges();

        }
        


        public async Task<CarInspection> GetById(int id)
        {
            return await _db.Inspecions.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task< IEnumerable<CarInspection>> GetAll()
        {
            return await _db.Inspecions.ToListAsync();
        }

        public async Task Update(CarInspection carInspection)
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

        public async Task Delete(int id)
        {
            var carInspection = await _db.Inspecions.FirstOrDefaultAsync(c => c.Id == id);
            if (carInspection != null)
            {
                _db.Remove(carInspection);
            }
        }

        public async Task SetConfirm(int id)
        {
            var inspection = await _db.Inspecions.FirstOrDefaultAsync(c => c.Id == id);

            if (inspection == null)
            {
                throw new Exception("Inspection not found!");
            }

            inspection.Status = InspectStatusEnum.Confirm;
            await _db.SaveChangesAsync(); 
        }

        public async Task SetCancell(int id)
        {
            var inspection = await _db.Inspecions.FirstOrDefaultAsync(c => c.Id == id);

            if (inspection == null)
            {
                throw new Exception("Inspection not found!");
            }

            inspection.Status = InspectStatusEnum.Cancel;
            await _db.SaveChangesAsync();
        }

    }
}