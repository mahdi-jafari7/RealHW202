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
    public class AdminRepository : IAdminRepository
    {

        private readonly InspectionDbContext _db;

        public AdminRepository(InspectionDbContext db)
        {
            _db = db;
        }

        public async Task<bool> PasswordIsValid(string username, string password)
        {
            return await _db.Admins.AnyAsync(a => a.Username == username && a.Password == password);

        }

    }
}
