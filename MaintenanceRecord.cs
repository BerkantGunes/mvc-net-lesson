using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika.Data.Model
{
    public class MaintenanceRecord
    {
        public int MaintenanceRecordId { get; set; }
        public int MachineId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string PerformedBy { get; set; }
        public Machine Machine { get; set; }
    }
}
