using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ClaimValue
    {
        public int Id { get; set; }
        public int InsuranceClaimId { get; set; }
        public int ParameterId { get; set; }
        public int? ValueId { get; set; }
        public string? Value { get; set; }

        public virtual InsuranceClaim1 InsuranceClaim { get; set; } = null!;
        public virtual Parameter1 Parameter { get; set; } = null!;
        public virtual Value1? ValueNavigation { get; set; }
    }
}
