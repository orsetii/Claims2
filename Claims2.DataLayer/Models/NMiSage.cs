using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class NMiSage
    {
        public string? Consignment { get; set; }
        public int? InvoiceNumber { get; set; }
        public double? NetAmount { get; set; }
        public double? TaxAmount { get; set; }
        public double? GrossAmount { get; set; }
        public double? CarrNet { get; set; }
        public double? CarrTax { get; set; }
        public double? CarrGross { get; set; }
        public double? InvoiceNet { get; set; }
        public double? InvoiceTax { get; set; }
        public double? InvoiceGross { get; set; }
        public DateTime DateInstructed { get; set; }
        public string? StockCode { get; set; }
        public string? Description { get; set; }
        public short? InvoiceTypeCode { get; set; }
        public string? AccountRef { get; set; }
    }
}
