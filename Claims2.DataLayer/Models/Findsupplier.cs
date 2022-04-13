using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Findsupplier
    {
        public string? VendorCode { get; set; }
        public string? AccountRef { get; set; }
        public string SupplierName { get; set; } = null!;
        public int SupplierId { get; set; }
    }
}
