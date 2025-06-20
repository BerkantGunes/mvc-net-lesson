using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika.Data.Model
{
    public class IncidentReport
    {
        public int IncidentReportId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string ReportedBy { get; set; }
    }
}
