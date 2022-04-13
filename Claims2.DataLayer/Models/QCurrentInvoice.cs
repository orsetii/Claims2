using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class QCurrentInvoice
    {
        public short? InvoiceTypeCode { get; set; }
        public string? Consignment { get; set; }
        public DateTime? InvoiceDate { get; set; }
    }
}
