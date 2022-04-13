using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class QSla91
    {
        public int InsuranceClaimId { get; set; }
        public int InsuranceClaimStatusId { get; set; }
        public DateTime StatusDate { get; set; }
        public string? AccountRef { get; set; }
        public bool Lock { get; set; }
    }
}
