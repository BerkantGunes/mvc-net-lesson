using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika.Data.Model
{
    public class Machine
    {
        public int MachineId { get; set; }
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
