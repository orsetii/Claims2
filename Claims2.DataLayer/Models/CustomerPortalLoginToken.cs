using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class CustomerPortalLoginToken
    {
        public int? InsuranceClaimId { get; set; }
        public string? Token { get; set; }
        public DateTime? TokenCreated { get; set; }
    }
}
