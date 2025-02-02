using Domain.Core._01_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core._02_Contracts.Services
{
    public interface ICarModelService
    {

        public void Add(string name, string manufacturer);

        public void Update(CarModel carmodel);
        public void Delete(int id);
        public CarModel GetById(int id);
        IEnumerable<CarModel> GetAll();
    }
}
