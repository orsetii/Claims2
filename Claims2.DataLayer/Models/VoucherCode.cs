using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class VoucherCode
    {
        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public int PurchaseOrderId { get; set; }
        public int SupplierId { get; set; }
        public string VoucherId { get; set; } = null!;
    }
}
