using Domain.Core._01_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core._02_Contracts.Services
{
    public interface IRejectedLogsService
    {
        public Task Add(RejectedLogs reject);

    }
}
