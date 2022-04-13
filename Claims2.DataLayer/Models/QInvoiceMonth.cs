using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class QInvoiceMonth
    {
        public int? InvoiceNumber { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string? MInvoice { get; set; }
        public string? Consignment { get; set; }
    }
}
