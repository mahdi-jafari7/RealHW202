using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core._02_Contracts.Repositories
{
    public interface IAdminRepository
    {
        public bool PasswordIsValid(string username, string password);

    }
}
