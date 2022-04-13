using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OrderPicked
    {
        public int Id { get; set; }
        public int PurchaseOrderNumber { get; set; }
        public string SupplierName { get; set; } = null!;
        public DateTime DateCreated { get; set; }
    }
}
