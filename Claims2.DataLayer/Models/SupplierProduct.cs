using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SupplierProduct
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
        /// <summary>
        /// A flag for new partial updates, a product in this state is not yet linked.
        /// </summary>
        public bool Updating { get; set; }
        public decimal? Rrp { get; set; }
        public string? SupplierReference { get; set; }
        public DateTime DateCreated { get; set; }
        public string? Url { get; set; }
    }
}
