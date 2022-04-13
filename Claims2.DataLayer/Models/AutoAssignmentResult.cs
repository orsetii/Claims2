using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class AutoAssignmentResult
    {
        public int Id { get; set; }
        public int? Aaid { get; set; }
        public int? Tasks { get; set; }
        public double? CommodityScore { get; set; }
        public int? InsuranceCompanyId { get; set; }
        public int? UserId { get; set; }
        public int? StatusId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public double? AutoAssignmentScore { get; set; }
        public bool? OverCapacity { get; set; }
        public bool? Online { get; set; }
        public int? SumInsCoLink { get; set; }
        public int? InsCoLink { get; set; }
        public bool? AssignedClaim { get; set; }
        public DateTime? DateAssigned { get; set; }
        public int? AssignedByUserId { get; set; }

        public virtual AutoAssignment? Aa { get; set; }
        public virtual User2? AssignedByUser { get; set; }
        public virtual User2? User { get; set; }
    }
}
