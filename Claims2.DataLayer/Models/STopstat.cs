using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class STopstat
    {
        public int? Count1 { get; set; }
        public string SupplierName { get; set; } = null!;
        public string? SOutcome { get; set; }
    }
}
