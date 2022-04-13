using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class QInspection
    {
        public int? InvoiceNumber { get; set; }
        public string? Consignment { get; set; }
        public string? AccountRef { get; set; }
        public string? StockCode { get; set; }
        public double? NetAmount { get; set; }
        public double? TaxAmount { get; set; }
        public double? GrossAmount { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public int? MiCat { get; set; }
        public string? Idate { get; set; }
    }
}
