using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SBerSupp
    {
        public int? SSupplierid { get; set; }
        public int? Outcount { get; set; }
        public string? Outdesc { get; set; }
        public string SupplierName { get; set; } = null!;
        public int? SOutcome { get; set; }
    }
}
