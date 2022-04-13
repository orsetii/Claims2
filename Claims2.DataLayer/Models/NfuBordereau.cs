using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class NfuBordereau
    {
        public int NfubId { get; set; }
        public int NfubSimId { get; set; }
        public DateTime? NfubIncidentDate { get; set; }
        public string? NfubSettlementType { get; set; }
    }
}
