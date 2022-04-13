using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class PaidExcess
    {
        public int PeId { get; set; }
        public int ClaimId { get; set; }
        public string AmountPaid { get; set; } = null!;
        public DateTime PaidDate { get; set; }
    }
}
