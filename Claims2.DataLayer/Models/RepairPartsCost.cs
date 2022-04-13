using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class RepairPartsCost
    {
        public int Id { get; set; }
        public string? Room { get; set; }
        public string? Name { get; set; }
        public int InspectionId { get; set; }
        public decimal Cost { get; set; }
        public int? Quantity { get; set; }
        public decimal? Unit { get; set; }
        public string? Specification { get; set; }
        public string? PreClaimCondition { get; set; }

        public virtual ItemInspection Inspection { get; set; } = null!;
    }
}
