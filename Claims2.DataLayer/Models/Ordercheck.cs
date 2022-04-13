using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Ordercheck
    {
        public int AliasInsuranceClaimId { get; set; }
        public int InsuranceClaimId { get; set; }
        public string VendorCode { get; set; } = null!;
        public int? InsuranceCompanyId { get; set; }
        public int LossAdjusterId { get; set; }
        public int ClaimOrderId { get; set; }
        public string ShortDescription { get; set; } = null!;
        public int ItemTypeId { get; set; }
    }
}
