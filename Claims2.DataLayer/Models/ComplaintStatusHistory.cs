using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ComplaintStatusHistory
    {
        public int ComplaintStatusHistoryId { get; set; }
        public int ComplaintId { get; set; }
        public int InsuranceClaimId { get; set; }
        public int ComplaintStatusId { get; set; }
        public string StatusComments { get; set; } = null!;
        public string? CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
