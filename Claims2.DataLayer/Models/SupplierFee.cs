using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SupplierFee
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public decimal Rrp { get; set; }
        public string Code { get; set; } = null!;
        public int FeeId { get; set; }
        public int SupplierId { get; set; }

        public virtual Fee Fee { get; set; } = null!;
        public virtual Supplier1 Supplier { get; set; } = null!;
    }
}
