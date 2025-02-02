using Domain.Core._02_Contracts.Repositories;
using Domain.Core._02_Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _repository;

        public AdminService(IAdminRepository repository)
        {
            _repository = repository;
        }
        public bool PasswordIsValid(string username, string password)
        {
            return _repository.PasswordIsValid(username, password);
        }

    }
}
