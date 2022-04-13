using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class QSageMonth
    {
        public int Clid { get; set; }
        public int? InvoiceNumber { get; set; }
        public short? InvoiceTypeCode { get; set; }
        public string? BDate { get; set; }
        public short? PostedCode { get; set; }
        public string? StockCode { get; set; }
        public double? NetAmount { get; set; }
        public double? TaxAmount { get; set; }
        public double? GrossAmount { get; set; }
    }
}
