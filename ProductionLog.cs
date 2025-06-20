using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika.Data.Model
{
    public class ProductionLog
    {
        public int ProductionLogId { get; set; }
        public int ProductionOrderId { get; set; }
        public int MachineId { get; set; }
        public int ProducedQuantity { get; set; }
        public DateTime Timestamp { get; set; }
        public ProductionOrder ProductionOrder { get; set; }
        public Machine Machine { get; set; }
    }
}
