using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldTblInsuranceCompany
    {
        public int InsuranceCompanyId { get; set; }
        public string? VendorCode { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public bool? DisplayOnWeb { get; set; }
        public int SortSequence { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string? UserName { get; set; }
        public string? UserPassword { get; set; }
        public string? SbsphoneContact { get; set; }
        public string? SbsfaxContact { get; set; }
        public int? TypeId { get; set; }
        public string? AccountsNotes { get; set; }
        public int CreditController { get; set; }
        public bool OverridesClaimHandler { get; set; }
        public bool Emailalert { get; set; }
        public bool MustDeliverToInvoice { get; set; }
        public bool MustContactToInvoice { get; set; }
    }
}
