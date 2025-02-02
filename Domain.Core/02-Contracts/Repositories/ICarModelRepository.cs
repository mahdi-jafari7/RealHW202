using Domain.Core._01_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core._02_Contracts.Repositories
{
    public interface ICarModelRepository
    {

        public void Add(CarModel carmodel);
        public void Update(CarModel carmodel);
        public void Delete(int id);
        public CarModel GetById(int id);
        IEnumerable<CarModel> GetAll();
    }
}
