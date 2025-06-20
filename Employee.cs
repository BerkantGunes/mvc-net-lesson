using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika.Data.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
