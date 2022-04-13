using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SupplierProductTemp
    {
        public int SupplierProductId { get; set; }
        public string? SupplierProductCode { get; set; }
        public string? SupplierProductCodeAlt { get; set; }
        public string Supplier { get; set; } = null!;
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string? Ean { get; set; }
        public string? Brand { get; set; }
        public int? BrandId { get; set; }
        public string? Description { get; set; }
        public int SupplierId { get; set; }
        public decimal? RetailPrice { get; set; }
        public string? SupplierReference { get; set; }
        public string? Url { get; set; }
    }
}
