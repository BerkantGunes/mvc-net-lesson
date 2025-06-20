using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika.Data.Model
{
    public class QualityCheck
    {
        public int QualityCheckId { get; set; }
        public int ProductId { get; set; }
        public DateTime CheckDate { get; set; }
        public string Result { get; set; } // Pass, Fail
        public string Notes { get; set; }
        public Product Product { get; set; }
    }
}
