using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika.Data.Model
{
    public class PurchaseOrderItem
    {
        public int PurchaseOrderItemId { get; set; }
        public int PurchaseOrderId { get; set; }
        public int InventoryItemId { get; set; }
        public double Quantity { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; }
        public InventoryItem InventoryItem { get; set; }
    }
}
