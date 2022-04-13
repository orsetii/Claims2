using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldTblInsuranceClaimStatusHistory
    {
        public int InsuranceClaimStatusHistoryId { get; set; }
        public int InsuranceClaimId { get; set; }
        public int InsuranceClaimStatusId { get; set; }
        public DateTime StatusDate { get; set; }
        public string? StatusComments { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public string ModifiedBy { get; set; } = null!;
        public DateTime DateModified { get; set; }
    }
}
