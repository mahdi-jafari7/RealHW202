using Domain.Core._02_Contracts.Repositories;
using Infra.db.Common;
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

        public bool PasswordIsValid(string username, string password)
        {
            return _db.Admins.Any(a => a.Username == username && a.Password == password);
        }
    }
}
