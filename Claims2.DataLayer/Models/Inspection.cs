using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Inspection
    {
        public int? InsuranceClaimId { get; set; }
        public string? Consignment { get; set; }
        public int? LossAdjusterId { get; set; }
        public int? InspCoId { get; set; }
        public string? InspCo { get; set; }
        public int? Openx { get; set; }
        public int? Closex { get; set; }
        public int? OutcomeId { get; set; }
        public string? Outcome { get; set; }
        public int? FaultTypeId { get; set; }
        public string? FaultType { get; set; }
        public int? ItemTypeId { get; set; }
        public string? ItemType { get; set; }
        public int? Updated { get; set; }
    }
}
