using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class MonthlyNewClaim
    {
        public int? ClaimRef { get; set; }
        public DateTime? InstructionDate { get; set; }
        public DateTime? DateClosed { get; set; }
        public string? UserName { get; set; }
        public string? AccountName { get; set; }
        public string? Commodity { get; set; }
        public string? Lareference { get; set; }
        public string? PolicyNumber { get; set; }
        public string? DeliverypostCode { get; set; }
        public int Id { get; set; }
        public int? Laid { get; set; }
        public string? ForTheMonth { get; set; }
        public int? ForTheYear { get; set; }
    }
}
