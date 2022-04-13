using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SBerRatio
    {
        public int? SSupplierid { get; set; }
        public string SupplierName { get; set; } = null!;
        public int? SOutcome { get; set; }
        public string? Outdesc { get; set; }
        public string Description { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public int? Createdmonth { get; set; }
    }
}
