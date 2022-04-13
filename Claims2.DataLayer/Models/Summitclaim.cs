using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Summitclaim
    {
        public string? Consn { get; set; }
        public DateTime DateInstructed { get; set; }
        public int LossAdjusterId { get; set; }
    }
}
