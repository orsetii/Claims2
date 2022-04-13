using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class AvivainvoicesSent
    {
        public int ClaimId { get; set; }
        public int InvoiceId { get; set; }
        public DateTime DateSent { get; set; }
        public string? RequestXml { get; set; }
        public string? ResponseXml { get; set; }
        public string? ErrorMessage { get; set; }
    }
}
