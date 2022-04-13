using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class CComplaint
    {
        public int ComplaintId { get; set; }
        public int ClaimId { get; set; }
        public string? Complainant { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public int? AssignedTo { get; set; }
        public int ComplaintType { get; set; }
        public int ComplaintStatus { get; set; }
        public string Text { get; set; } = null!;
        public DateTime? DateResolved { get; set; }
        public bool? ComplaintJustified { get; set; }
        public string? Resolution { get; set; }
        public string? CompensationType { get; set; }
        public decimal? CompensationAmount { get; set; }
        public string? CompensationReason { get; set; }
        public DateTime? DateReceived { get; set; }

        public virtual InsuranceClaim1 Claim { get; set; } = null!;
    }
}
