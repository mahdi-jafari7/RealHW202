using Domain.Core._01_Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.db.Common
{
    public static class CarModelSeedData
    {
        public static void CarModelSeed(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<CarModel>().HasData(
            //    new CarModel
            //    {
            //        Id = 1,
            //        Name = "Peride"
            //        , Manufacturer = "Saipa"
            //    }
            //);
        }
    }
}
