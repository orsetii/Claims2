using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SFaultAnalysis
    {
        public int? SSupplierid { get; set; }
        public string SupplierName { get; set; } = null!;
        public int? SOutcome { get; set; }
        public string? Outdesc { get; set; }
        public string Description { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public int? STlId { get; set; }
        public string? STlDesc { get; set; }
        public string? SSlDesc { get; set; }
        public int? SFaultType { get; set; }
        public string? Faultdesc { get; set; }
        public string? SStatusDesc { get; set; }
        public int? Createdmonth { get; set; }
    }
}
