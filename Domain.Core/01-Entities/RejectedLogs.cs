using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core._01_Entities
{
    public class RejectedLogs
    {
        public int Id { get; set; }
        public DateTime RequestDate { get; set; }
        public string PlateNumber { get; set; }
        public int CarModelId { get; set; }
        public string OwnerNationalId { get; set; }
        public int ProductionYear { get; set; }
        public string OwnerPhoneNumber { get; set; }
        public string OwnerAdress { get; set; }
        

        public DateTime LogDate { get; set; }
    }
}
