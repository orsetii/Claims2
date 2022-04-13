using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Claimant
    {
        public int ClaimantId { get; set; }
        public string? Title1 { get; set; }
        public string? FirstName1 { get; set; }
        public string? LastName1 { get; set; }
        public string? Title2 { get; set; }
        public string? FirstName2 { get; set; }
        public string? LastName2 { get; set; }
        public string? Haddress1 { get; set; }
        public string? Haddress2 { get; set; }
        public string? Haddress3 { get; set; }
        public string? Haddress4 { get; set; }
        public string? Hpostcode { get; set; }
        public string? Daddress1 { get; set; }
        public string? Daddress2 { get; set; }
        public string? Daddress3 { get; set; }
        public string? Daddress4 { get; set; }
        public string? Dpostcode { get; set; }
        public string? HomeTel { get; set; }
        public string? WorkTel { get; set; }
        public string? Mobile { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public bool IsCompany { get; set; }
        public string? CompanyName { get; set; }
        public bool IsVatreg { get; set; }
        public string? VatregNo { get; set; }
    }
}
