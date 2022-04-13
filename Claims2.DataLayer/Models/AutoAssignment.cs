using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class AutoAssignment
    {
        public AutoAssignment()
        {
            AutoAssignmentResults = new HashSet<AutoAssignmentResult>();
        }

        public int Id { get; set; }
        public int? ClaimId { get; set; }
        public int BusyCoeff { get; set; }
        public int CommodityCoeff { get; set; }
        public int CommodityId { get; set; }
        public int? InsuranceCompanyId { get; set; }
        public bool? Technical { get; set; }
        public bool? HighValue { get; set; }

        public virtual ICollection<AutoAssignmentResult> AutoAssignmentResults { get; set; }
    }
}
