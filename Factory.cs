using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika.Data.Model
{
    public class Factory
    {
        public int FactoryId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
