using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ClaimProfit
    {
        public int InsuranceClaimId { get; set; }
        public string Consignment { get; set; } = null!;
        public bool Poraised { get; set; }
        public DateTime? Podate { get; set; }
        public bool Invraised { get; set; }
        public DateTime? Invdate { get; set; }
        public decimal? PoitemsNet { get; set; }
        public decimal? PoitemsGross { get; set; }
        public decimal? PocarriageNet { get; set; }
        public decimal? PocarriageGross { get; set; }
        public decimal? Ponet { get; set; }
        public decimal? Pogross { get; set; }
        public decimal? InvitemsNet { get; set; }
        public decimal? InvitemsGross { get; set; }
        public decimal? InvcarriageNet { get; set; }
        public decimal? Invcarriagegross { get; set; }
        public decimal? Invnet { get; set; }
        public decimal? Invgross { get; set; }
        public decimal? ProfititemsNet { get; set; }
        public decimal? ProfititemsGross { get; set; }
        public decimal? ProfitcarriageNet { get; set; }
        public decimal? ProfitcarriageGross { get; set; }
        public decimal? Profitnet { get; set; }
        public decimal? Profitgross { get; set; }
    }
}
