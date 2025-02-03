using Domain.Core._01_Entities;
using Domain.Core._02_Contracts.Repositories;
using Domain.Core._02_Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class RejectedLogsService : IRejectedLogsService
    {

        private readonly IRejectedLogsRepository rejectedLogsRepository;
        public RejectedLogsService(IRejectedLogsRepository _rejectedLogsRepository)
        {
            rejectedLogsRepository= _rejectedLogsRepository;
        }

        public async Task Add(RejectedLogs reject)
        {
            await rejectedLogsRepository.Add(reject);
        }
    }
}
