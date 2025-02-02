using Domain.Core._01_Entities;
using Domain.Core._02_Contracts.Repositories;
using Infra.db.Common;
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

        public void Add(RejectedLogs log)
        {

            log.LogDate = CarInspection.GetPersianDateAsDateTime(DateTime.Now);
            _db.RejectedLogs.Add(log);
            _db.SaveChanges();
        }

        public RejectedLogs GetById(int id)
        {
            return _db.RejectedLogs.FirstOrDefault(l => l.Id == id);
        }

        public IEnumerable<RejectedLogs> GetAll()
        {
            return _db.RejectedLogs.ToList();
        }

       

    }
}
