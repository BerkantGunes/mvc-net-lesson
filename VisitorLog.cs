using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika.Data.Model
{
    public class VisitorLog
    {
        public int VisitorLogId { get; set; }
        public string VisitorName { get; set; }
        public DateTime VisitDate { get; set; }
        public string Purpose { get; set; }
    }
}
