using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldSInspItem
    {
        public int SInspItem { get; set; }
        public int? SClaimId { get; set; }
        public int? SClaimItemId { get; set; }
        public string? SContact { get; set; }
        public string? STitle { get; set; }
        public string? SFirstname { get; set; }
        public string? SLastname { get; set; }
        public string? SAddress1 { get; set; }
        public string? SAddress2 { get; set; }
        public string? SAddress3 { get; set; }
        public string? SAddress4 { get; set; }
        public string? SPostcode { get; set; }
        public string? SDName { get; set; }
        public string? SDAddress1 { get; set; }
        public string? SDAddress2 { get; set; }
        public string? SDAddress3 { get; set; }
        public string? SDAddress4 { get; set; }
        public string? SDPostcode { get; set; }
        public string? SPhonehome { get; set; }
        public string? SPhonework { get; set; }
        public string? SPhonemobile { get; set; }
        public int? SProductType { get; set; }
        public string? SItemDesc { get; set; }
        public int? SInspType { get; set; }
        public int? SInspCompany { get; set; }
        public int? SInsCompany { get; set; }
        public string? SCreatedBy { get; set; }
        public DateTime? SCreatedOn { get; set; }
        public bool? SConfirmed { get; set; }
        public string? SSpecInstr { get; set; }
        public int? SStatus { get; set; }
        public DateTime? SLastUpdated { get; set; }
        public string? SStatusComments { get; set; }
        public int? SDelAccId { get; set; }
        public string? SDelRef { get; set; }
    }
}
