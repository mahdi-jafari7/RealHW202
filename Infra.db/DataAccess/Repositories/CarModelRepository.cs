using Domain.Core._01_Entities;
using Domain.Core._02_Contracts.Repositories;
using Infra.db.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Infra.db.DataAccess.Repositories
{
    public class CarModelRepository : ICarModelRepository
    {
        private readonly InspectionDbContext db;

        public CarModelRepository(InspectionDbContext _db)
        {
            db = _db;
        }
        public async Task Add(CarModel carmodel)
        {
            await db.CarModels.AddAsync(carmodel);
            await db.SaveChangesAsync();
        }

        public async Task<bool> Delete(int id)
        {
            var car = await GetById(id);
            if (car == null) return false;

            db.CarModels.Remove(car);
            await db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Update(CarModel carmodel)
        {
            var existingCar = await GetById(carmodel.Id);
            if (existingCar == null) return false;

            existingCar.Name = carmodel.Name;
            existingCar.Manufacturer = carmodel.Manufacturer;

            await db.SaveChangesAsync();
            return true;
        }

        public async Task<CarModel> GetById(int id)
        {
            return await db.CarModels.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<CarModel>> GetAll()
        {
            return await db.CarModels.ToListAsync();
        }
    }
}



