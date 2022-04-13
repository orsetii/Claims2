using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Summit2
    {
        public string? Consn { get; set; }
        public DateTime DateInstructed { get; set; }
        public int LossAdjusterId { get; set; }
        public string? Consignment { get; set; }
        public int? InvoiceNumber { get; set; }
        public string? InvoiceType { get; set; }
        public string? AccountRef { get; set; }
        public string? StockCode { get; set; }
        public string AccountName { get; set; } = null!;
        public string? AccountRef1 { get; set; }
    }
}
