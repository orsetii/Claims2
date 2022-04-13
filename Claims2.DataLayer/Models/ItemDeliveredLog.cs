using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ItemDeliveredLog
    {
        public int? InsuranceClaimId { get; set; }
        public int? ClaimOrderId { get; set; }
        public DateTime? DateChecked { get; set; }
        public int? RetVal { get; set; }
        public int? PoStatus { get; set; }
        public int? PoNewStatus { get; set; }
        public bool? PoReq { get; set; }
    }
}
