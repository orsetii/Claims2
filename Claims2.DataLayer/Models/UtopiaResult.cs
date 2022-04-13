using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class UtopiaResult
    {
        public int ResultId { get; set; }
        public int ClaimId { get; set; }
        public double WithdrawalConfidence { get; set; }
        public double ComplaintConfidence { get; set; }
        public DateTime ResultDate { get; set; }
    }
}
