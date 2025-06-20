using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika.Data.Model
{
    public class InventoryTransaction
    {
        public int InventoryTransactionId { get; set; }
        public int InventoryItemId { get; set; }
        public DateTime Date { get; set; }
        public double Quantity { get; set; }
        public string TransactionType { get; set; } // IN, OUT, ADJUSTMENT
        public InventoryItem InventoryItem { get; set; }
    }
}
