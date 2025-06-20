using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika.Data.Model
{
    public class EmployeeShift
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int ShiftId { get; set; }
        public DateTime ShiftDate { get; set; }
        public Employee Employee { get; set; }
        public Shift Shift { get; set; }
    }
}
