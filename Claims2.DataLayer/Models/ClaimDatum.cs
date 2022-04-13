using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ClaimDatum
    {
        public int? CoClaimId { get; set; }
        public string? CoLaRef { get; set; }
        public string? Handler { get; set; }
        public string? Policynumber { get; set; }
        public string? CoLaName { get; set; }
        public string? Peril { get; set; }
        public string? Perildetail { get; set; }
        public string? Username { get; set; }
        public string? Claimcommodity { get; set; }
        public string? Claimtypedescription { get; set; }
        public string? Insuredlastname { get; set; }
        public string? Insuredpostcode { get; set; }
        public string? Hometelephone { get; set; }
        public string? Worktelephone { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public string? Vatregistered { get; set; }
        public string? CoInsco { get; set; }
        public DateTime? CoDateOpened { get; set; }
        public DateTime? CoDateClosed { get; set; }
        public string? CoCommodity { get; set; }
        public string? CoPeril { get; set; }
        public string? CoOutcome { get; set; }
        public string? CoClaimOutcome { get; set; }
        public string? IiSupplier { get; set; }
        public string? IiGoodsCost { get; set; }
        public string? IiCarriageCost { get; set; }
        public string? IiDescription { get; set; }
        public string? IiNet { get; set; }
        public string? IiGross { get; set; }
        public DateTime? IiDate { get; set; }
        public string? IiInvNo { get; set; }
        public string? IiProductCode { get; set; }
        public string? IiQuantity { get; set; }
        public string? IiPoNumber { get; set; }
        public DateTime? IiPoOriginalDate { get; set; }
        public DateTime? IiPoConfirmedDate { get; set; }
        public DateTime? IiPoDelDateConfirmed { get; set; }
        public DateTime? IiPoDelDateEst { get; set; }
        public string? Itemtype { get; set; }
        public int? Itemid { get; set; }
        public int? IiClaimorderid { get; set; }
        public string? Suppliername { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public double? Claimvalue { get; set; }
        public string? Lareference { get; set; }
        public string? Claimtype { get; set; }
        public int? Gmgnid { get; set; }
        public bool? TechnicalClaim { get; set; }
        public int LineItemCategory { get; set; }
        public int Id { get; set; }
    }
}
