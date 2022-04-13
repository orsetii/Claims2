using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class QCarriageNew
    {
        public int? InvoiceNumber { get; set; }
        public string? Consignment { get; set; }
        public string? AccountRef { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public double? GrossAmount { get; set; }
        public string? Idate { get; set; }
    }
}
