using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Suppliercheck
    {
        public int SupplierId { get; set; }
        public string? VendorCode { get; set; }
        public string? AccountRef { get; set; }
        public string SupplierName { get; set; } = null!;
        public string CreatedBy { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
