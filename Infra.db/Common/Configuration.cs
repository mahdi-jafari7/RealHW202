using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.db.Common
{
    public static class Configuration
    {
        public static void Configure(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(
                "Server=LAPTOP-01HRT8HI\\SQLEXPRESS;Database=InspectionDbContext;Integrated Security=true;TrustServerCertificate=True");

        }
    }
}
