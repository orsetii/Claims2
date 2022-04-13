using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ReciperoCheck
    {
        public int CheckId { get; set; }
        public int ClaimId { get; set; }
        public string? WellFormedImei { get; set; }
        public string? Manufacturer { get; set; }
        public string? Model { get; set; }
        public string? Fmipstatus { get; set; }
        public string? CheckmendSearch { get; set; }
        public string? CheckmendStatus { get; set; }
        public string? NetworkBlocked { get; set; }
        public string? PreviousClaims { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
