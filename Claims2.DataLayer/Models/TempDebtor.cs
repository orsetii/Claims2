using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class TempDebtor
    {
        public int DrId { get; set; }
        public int DrLaId { get; set; }
        public int DrInsCoId { get; set; }
        public int DrClaimId { get; set; }
        public string? DrName { get; set; }
        public string DrTranType { get; set; } = null!;
        public DateTime DrDate { get; set; }
        public string? DrInvNo { get; set; }
        public decimal? DrBalance { get; set; }
    }
}
