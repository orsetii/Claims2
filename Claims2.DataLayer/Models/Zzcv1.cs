using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Zzcv1
    {
        public string? StockCode { get; set; }
        public int? InvoiceNumber { get; set; }
        public string? AccountRef { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string? Consignment { get; set; }
    }
}
