using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class AllianzAssignment
    {
        public int Id { get; set; }
        public string AllianzClaimId { get; set; } = null!;
        public string? DeviceId { get; set; }
        public string AssignmentNumber { get; set; } = null!;
        public string? AssignmentId { get; set; }
        public string? Status { get; set; }
        public decimal? CoverageAmount { get; set; }
        public string? ServiceProviderId { get; set; }
    }
}
