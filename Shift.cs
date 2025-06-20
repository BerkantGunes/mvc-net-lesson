using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika.Data.Model
{
    public class Shift
    {
        public int ShiftId { get; set; }
        public string Name { get; set; } // e.g., "Morning", "Night"
        public TimeSpan Start { get; set; }
        public TimeSpan End { get; set; }
    }
}
