﻿using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class QReplace
    {
        public int? InvoiceNumber { get; set; }
        public string? Consignment { get; set; }
        public string? AccountRef { get; set; }
        public string? StockCode { get; set; }
        public string? Description { get; set; }
        public double? NetAmount { get; set; }
        public double? TaxAmount { get; set; }
        public double? GrossAmount { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string? Idate { get; set; }
        public short? InvoiceTypeCode { get; set; }
        public short? PostedCode { get; set; }
    }
}
