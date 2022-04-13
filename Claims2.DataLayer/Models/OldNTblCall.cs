using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldNTblCall
    {
        public int CallId { get; set; }
        public int? CallProfId { get; set; }
        public string? CallNotes { get; set; }
        public int? CallBy { get; set; }
        public DateTime? CallOn { get; set; }
        public int? InsuranceClaimId { get; set; }
        public int? WarrantyClaimId { get; set; }
        public bool? CallAnswered { get; set; }
        public bool? ReturnCallRequired { get; set; }
        public bool? NameQ { get; set; }
        public bool? PostCodeQ { get; set; }
        public bool? AddressQ { get; set; }
        public bool? ClaimReferenceQ { get; set; }
        public bool? TelephoneNumberQ { get; set; }
    }
}
