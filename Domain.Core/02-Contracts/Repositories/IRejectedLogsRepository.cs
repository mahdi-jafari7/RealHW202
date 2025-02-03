using Domain.Core._01_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core._02_Contracts.Repositories
{
    public interface IRejectedLogsRepository
    {

        public  Task Add(RejectedLogs log);
        public  Task<RejectedLogs?> GetById(int id);
        public  Task<List<RejectedLogs>> GetAll();


    }
}
