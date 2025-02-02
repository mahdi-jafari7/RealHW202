using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core._02_Contracts.AppServices
{
    public interface IAdminAppService
    {
        public bool PasswordIsValid(string username, string password);

    }
}
