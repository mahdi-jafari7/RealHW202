using Domain.Core._01_Entities;
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
    public class RejectedLogsAppService : IRejectedLogsAppService
    {
        private readonly IRejectedLogsService rejectedLogsService;
        public RejectedLogsAppService(IRejectedLogsService _rejectedLogsService)
        {
            rejectedLogsService = _rejectedLogsService;
        }

        public void Add(RejectedLogs reject)
        {
            rejectedLogsService.Add(reject);
        }

    }
}
