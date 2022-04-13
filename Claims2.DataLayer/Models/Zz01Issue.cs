using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Zz01Issue
    {
        public int? InvoiceNumber { get; set; }
        public string? AccountRef { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string? Consignment { get; set; }
        public string? StockCode { get; set; }
        public double? NetAmount { get; set; }
        public double? TaxAmount { get; set; }
    }
}
