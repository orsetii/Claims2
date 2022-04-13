using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class TempNlJournal
    {
        public int NljId { get; set; }
        public DateTime NljDate { get; set; }
        public int NljTransPeriod { get; set; }
        public int NljAccountingPeriod { get; set; }
        public int NljDCode { get; set; }
        public int NljCCode { get; set; }
        public string? NljNarrative { get; set; }
        public decimal NljAmount { get; set; }
    }
}
