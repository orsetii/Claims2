using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class NfuagencyDetail
    {
        public int? BranchNumber { get; set; }
        public string IntermediaryClrf { get; set; } = null!;
        public string? BoomerangName { get; set; }
        public string? AlsoKnownAs { get; set; }
        public string? BoomerangNumber { get; set; }
        public string? Commissioned { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? AddressLine3 { get; set; }
        public string? AddressLine4 { get; set; }
        public string? AddressLine5 { get; set; }
        public string? AddressLine6 { get; set; }
        public string? Postcode { get; set; }
        public string? EmailAddress { get; set; }
        public string? Column15 { get; set; }
    }
}
