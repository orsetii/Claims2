using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class NlMonthly
    {
        public int NlmId { get; set; }
        public int NlmNlaId { get; set; }
        public int NlmAccountingPeriod { get; set; }
        public string? NlmPostingType { get; set; }
        public decimal NlmValue { get; set; }
    }
}
