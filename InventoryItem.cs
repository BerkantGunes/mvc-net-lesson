using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika.Data.Model
{
    public class InventoryItem
    {
        public int InventoryItemId { get; set; }
        public string ItemCode { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public double Quantity { get; set; }
    }
}
