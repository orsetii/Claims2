using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SStatusCount
    {
        public string ProductCode { get; set; } = null!;
        public int? SStatus { get; set; }
        public string? SStatusDesc { get; set; }
        public int SInspectionId { get; set; }
        public int? SSupplierid { get; set; }
        public string SupplierName { get; set; } = null!;
        public int? CreatedMonth { get; set; }
    }
}
