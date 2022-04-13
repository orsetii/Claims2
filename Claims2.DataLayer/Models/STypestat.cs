using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class STypestat
    {
        public int? Count1 { get; set; }
        public string SupplierName { get; set; } = null!;
        public string? SStatusDesc { get; set; }
        public int? SStatus { get; set; }
    }
}
