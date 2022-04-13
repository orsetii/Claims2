using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SupplierService
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public decimal Rrp { get; set; }
        public string Code { get; set; } = null!;
        public int ServiceId { get; set; }
        public int SupplierId { get; set; }

        public virtual Service Service { get; set; } = null!;
        public virtual Supplier1 Supplier { get; set; } = null!;
    }
}
