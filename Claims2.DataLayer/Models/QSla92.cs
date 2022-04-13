using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class QSla92
    {
        public bool Lock { get; set; }
        public int InsuranceClaimId { get; set; }
        public DateTime? Closedate { get; set; }
    }
}
