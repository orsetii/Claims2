using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class _22012020supplierProduct
    {
        public int SupplierProductId { get; set; }
        public string SupplierProductCode { get; set; } = null!;
        public string? SupplierProductCodeAlt { get; set; }
        public string Supplier { get; set; } = null!;
        public int? Quantity { get; set; }
        public double Price { get; set; }
        public string? Ean { get; set; }
        public string? Brand { get; set; }
        public int? BrandId { get; set; }
        public string? Description { get; set; }
        public double? AltPrice { get; set; }
        public int SupplierId { get; set; }
        public bool Updating { get; set; }
        public decimal? Rrp { get; set; }
        public string? SupplierReference { get; set; }
        public DateTime DateCreated { get; set; }
        public string? Url { get; set; }
    }
}
