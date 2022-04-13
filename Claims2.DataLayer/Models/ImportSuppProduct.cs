using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ImportSuppProduct
    {
        public string? Mpncode { get; set; }
        public string? Supplier { get; set; }
        public string? Stock { get; set; }
        public string? Price { get; set; }
        public string? Ean { get; set; }
        public string? Manufacturer { get; set; }
        public string? Description { get; set; }
        public string? RetailPrice { get; set; }
        public string? SupplierReference { get; set; }
        public string? Url { get; set; }
    }
}
