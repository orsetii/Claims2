using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class NewmiDateClosed
    {
        public DateTime? DateClosed { get; set; }
        public int InsuranceClaimId { get; set; }
        public int Expr1 { get; set; }
        public int? OutcomeId { get; set; }
    }
}
