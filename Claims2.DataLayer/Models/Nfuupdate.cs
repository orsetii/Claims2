using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Nfuupdate
    {
        public int UpdateId { get; set; }
        public int InsuranceClaimId { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Updated { get; set; }
        public DateTime? DateSent { get; set; }
        public DateTime DateUpdateRequired { get; set; }
    }
}
