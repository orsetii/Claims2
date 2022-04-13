using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Riaccessory
    {
        public int AccessoryId { get; set; }
        public int ReplacementId { get; set; }
        public int ProductId { get; set; }
        public int SupplierProductId { get; set; }
        public string? Supplier { get; set; }
        public string? Brand { get; set; }
        public string? SupplierProductCode { get; set; }
        public double? Price { get; set; }
        public int? Quantity { get; set; }
    }
}
