using Domain.Core._02_Contracts.AppServices;
using Domain.Core._02_Contracts.Repositories;
using Domain.Core._02_Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AppService
{
    public class AdminAppService : IAdminAppService
    {
        private readonly IAdminService _service;

        public AdminAppService(IAdminService service)
        {
            _service = service;
        }
        public async Task<bool> PasswordIsValid(string username, string password)
        {
            return await _service.PasswordIsValid(username, password);
        }
    }
}
