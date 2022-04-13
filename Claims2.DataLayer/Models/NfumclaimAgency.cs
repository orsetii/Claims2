using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class NfumclaimAgency
    {
        public int Id { get; set; }
        public int ValClaimId { get; set; }
        public int? InsuranceClaimId { get; set; }
        public int? AgencyRef { get; set; }
    }
}
