using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class QBookedOnClaim
    {
        public int InsuranceClaimId { get; set; }
        public string? Bmonth { get; set; }
        public string? Bdate { get; set; }
        public int? StatusSublevelId { get; set; }
        public int UserId { get; set; }
        public int CauseTypeId { get; set; }
        public int ItemTypeId { get; set; }
        public int LossAdjusterId { get; set; }
    }
}
