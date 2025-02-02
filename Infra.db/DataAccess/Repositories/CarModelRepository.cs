using Domain.Core._01_Entities;
using Domain.Core._02_Contracts.Repositories;
using Infra.db.Common;
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
        public void Add(CarModel carmodel)
        {
            
            db.CarModels.Add(carmodel);
            db.SaveChanges();

        }

        public void Delete(int id)
        {
            db.CarModels.Remove(GetById(id));
            db.SaveChanges();

        }

        public void Update(CarModel carmodel)
        {
            var existingCar = GetById(carmodel.Id);
            if (existingCar != null)
            {
                existingCar.Name = carmodel.Name;
                existingCar.Manufacturer = carmodel.Manufacturer;
            }
        }

        public CarModel GetById(int id)
        {
            return db.CarModels.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<CarModel> GetAll()
        {
            return db.CarModels.ToList();
        }

    }
}
