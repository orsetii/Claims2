using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Country
    {
        public int CountryId { get; set; }
        public string? AliasCountryId { get; set; }
        public string CountryCode { get; set; } = null!;
        public string? SageCountryCode { get; set; }
        public string Description { get; set; } = null!;
        public bool Deleted { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
