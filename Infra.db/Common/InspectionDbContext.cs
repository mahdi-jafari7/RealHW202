using Domain.Core._01_Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


namespace Infra.db.Common
{
    public class InspectionDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Configuration.Configure(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AdminSeedData.Seed(modelBuilder);
            
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<CarInspection> Inspecions { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<RejectedLogs> RejectedLogs { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }

}

