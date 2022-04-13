using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldWClaim
    {
        public int WClaimId { get; set; }
        public int? WClaimPolicyId { get; set; }
        public string? WClaimPolicyNum { get; set; }
        public int WClaimHandler { get; set; }
        public DateTime? WClaimPolicyStart { get; set; }
        public DateTime? WClaimPolicyExpires { get; set; }
        public DateTime WClaimDate { get; set; }
        public int WClaimStatus { get; set; }
        public bool? WClaimOpen { get; set; }
        public bool WClaimMadeWithinInitialPeriod { get; set; }
        public int? WClaimItemCategory { get; set; }
        public int? WClaimItemType { get; set; }
        public string? WClaimManufacturer { get; set; }
        public string? WClaimModel { get; set; }
        public string? WClaimSerial { get; set; }
        public string? WClaimName { get; set; }
        public string? WClaimPhone { get; set; }
        public string? WClaimMobile { get; set; }
        public string? WClaimFax { get; set; }
        public string? WClaimAdd1 { get; set; }
        public string? WClaimAdd2 { get; set; }
        public string? WClaimAdd3 { get; set; }
        public string? WClaimPostcode { get; set; }
        public string? WClaimAltadd1 { get; set; }
        public string? WClaimAltadd2 { get; set; }
        public string? WClaimAltadd3 { get; set; }
        public string? WClaimAltpostcode { get; set; }
        public string? WClaimComments { get; set; }
        public string? WClaimDetails { get; set; }
        public int? WClaimRepairer { get; set; }
        public string? WClaimRepairType { get; set; }
        public int? WClaimDeliveryComp { get; set; }
        public string? WClaimDeliveryRef { get; set; }
        public DateTime? WClaimExpDeliveryDate { get; set; }
        public string? WClaimCondition { get; set; }
        public string? WClaimEngineer { get; set; }
        public string? WClaimDamageDetails { get; set; }
        public int? WClaimFaultTypeId { get; set; }
        public int? WClaimInspectionResultId { get; set; }
        public int? WClaimFromCompany { get; set; }
    }
}
