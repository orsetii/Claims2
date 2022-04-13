using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class GrossNonItem
    {
        public string? Consignment { get; set; }
        public int? InvoiceNumber { get; set; }
        public short? InvoiceTypeCode { get; set; }
        public string? StockCode { get; set; }
        public double? GrossAmount { get; set; }
        public int? MiCat { get; set; }
        public string? MiDesc { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string? AccountRef { get; set; }
    }
}
