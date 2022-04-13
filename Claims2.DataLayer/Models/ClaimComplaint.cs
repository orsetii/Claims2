using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ClaimComplaint
    {
        public int ClaimComplaintId { get; set; }
        public string? AliasClaimComplaintId { get; set; }
        public int InsuranceClaimId { get; set; }
        public int ComplaintStatusId { get; set; }
        public string Description { get; set; } = null!;
        public string? Comments { get; set; }
        public bool? DisplayOnWeb { get; set; }
        public int? SortSequence { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
