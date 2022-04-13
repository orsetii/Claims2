using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class CancelPo
    {
        public int Id { get; set; }
        public int PurchaseOrderNumber { get; set; }
        public string SupplierName { get; set; } = null!;
    }
}
