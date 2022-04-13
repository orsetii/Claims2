using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class BastionTrojanRequest
    {
        public int TrojanId { get; set; }
        public int ClaimId { get; set; }
        public string? InboundTrackingNo { get; set; }
        public DateTime? DateOut { get; set; }
        public string? OutboundTrackingNo { get; set; }
        public string? WorkDone { get; set; }
        public double? Labour { get; set; }
        public double? Parts { get; set; }
        public double? Postage { get; set; }
        public double? SubTotal { get; set; }
        public double? Vat { get; set; }
        public double? Gross { get; set; }
        public string? RepairerId { get; set; }
        public string? QuoteReserve { get; set; }
        public string? VatStatus { get; set; }
        public bool TrojanSent { get; set; }
        public DateTime? SentDate { get; set; }
    }
}
