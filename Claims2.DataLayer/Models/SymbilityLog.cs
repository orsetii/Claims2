using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SymbilityLog
    {
        public int SymbilityLogId { get; set; }
        public int InsuranceClaimId { get; set; }
        public string? MessageType { get; set; }
        public string RequestJson { get; set; } = null!;
        public string? ReplyJson { get; set; }
        public DateTime RequestSentOn { get; set; }
        public string? Source { get; set; }
        public string? CallStack { get; set; }
    }
}
