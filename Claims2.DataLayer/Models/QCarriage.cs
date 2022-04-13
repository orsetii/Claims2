using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class QCarriage
    {
        public int? InvoiceNumber { get; set; }
        public string? Consignment { get; set; }
        public string? AccountRef { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public double? CarrNet { get; set; }
        public double? CarrTax { get; set; }
        public double? CarrGross { get; set; }
    }
}
