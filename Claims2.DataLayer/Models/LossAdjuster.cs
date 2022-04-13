using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class LossAdjuster
    {
        public int LossAdjusterId { get; set; }
        public string? VendorCode { get; set; }
        public string? AccountRef { get; set; }
        public string AccountName { get; set; } = null!;
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string? Address4 { get; set; }
        public string? Address5 { get; set; }
        public string? PostCode { get; set; }
        public string? Country { get; set; }
        public string? Contact { get; set; }
        public string? Telephone { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? Website { get; set; }
        public string? Reference { get; set; }
        public int? LossAdjusterGroupId { get; set; }
        public int ClaimCloseDays { get; set; }
        public decimal MinimumValueToQuote { get; set; }
        public bool Deleted { get; set; }
        public bool? DisplayOnWeb { get; set; }
        public int SortSequence { get; set; }
        public string? Tag { get; set; }
        public string? Comments { get; set; }
        public string Ipaddress { get; set; } = null!;
        public string CreatedBy { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public string ModifiedBy { get; set; } = null!;
        public DateTime DateModified { get; set; }
        public int? AutoInvoiceItem { get; set; }
        public int InsCompanyId { get; set; }
        public string? AccountsNotes { get; set; }
        public int RegionId { get; set; }
        public int NfuType { get; set; }

        public virtual InsuranceCompany InsCompany { get; set; } = null!;
    }
}
