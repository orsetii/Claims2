using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class InvoiceItem
    {
        public int? InvoiceNumber { get; set; }
        public short? ItemNumber { get; set; }
        public string? JobNumber { get; set; }
        public short? ServiceFlag { get; set; }
        public string? Description { get; set; }
        public string? Text { get; set; }
        public string? StockCode { get; set; }
        public string? Comment1 { get; set; }
        public string? Comment2 { get; set; }
        public string? UnitOfSale { get; set; }
        public double? Quantity { get; set; }
        public double? ForeignUnitPrice { get; set; }
        public double? ForeignDiscountAmount { get; set; }
        public double? UnitPrice { get; set; }
        public double? DiscountAmount { get; set; }
        public double? DiscountRate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string? NominalCode { get; set; }
        public short? DeptNumber { get; set; }
        public string? DeptName { get; set; }
        public string? TaxCode { get; set; }
        public double? AddDiscRate { get; set; }
        public double? TaxRate { get; set; }
        public double? FullNetAmount { get; set; }
        public double? NetAmount { get; set; }
        public double? TaxAmount { get; set; }
        public double? GrossAmount { get; set; }
        public double? ForeignFullNetAmount { get; set; }
        public double? ForeignNetAmount { get; set; }
        public double? ForeignTaxAmount { get; set; }
        public double? ForeignGrossAmount { get; set; }
        public string? ExtOrderRef { get; set; }
        public int? ExtOrderLineRef { get; set; }
    }
}
