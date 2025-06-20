using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika.Data.Model
{
    public class UtilityUsage
    {
        public int UtilityUsageId { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; } // Electricity, Water, Gas
        public double Amount { get; set; }
    }
}
