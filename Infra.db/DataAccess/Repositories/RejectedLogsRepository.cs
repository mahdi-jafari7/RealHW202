using Domain.Core._01_Entities;
using Domain.Core._02_Contracts.Repositories;
using Infra.db.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.db.DataAccess.Repositories
{
    public class RejectedLogsRepository : IRejectedLogsRepository
    {

        private readonly InspectionDbContext _db;

        public RejectedLogsRepository(InspectionDbContext db)
        {
            _db = db;
        }

        public async Task Add(RejectedLogs log)
        {
            log.LogDate = CarInspection.GetPersianDateAsDateTime(DateTime.Now);
            await _db.RejectedLogs.AddAsync(log);
            await _db.SaveChangesAsync();
        }

        public async Task<RejectedLogs?> GetById(int id)
        {
            return await _db.RejectedLogs.FirstOrDefaultAsync(l => l.Id == id);
        }

        public async Task<List<RejectedLogs>> GetAll()
        {
            return await _db.RejectedLogs.ToListAsync();
        }

    }
}


