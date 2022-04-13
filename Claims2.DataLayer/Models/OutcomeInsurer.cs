using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OutcomeInsurer
    {
        public int Id { get; set; }
        public int OutcomeId { get; set; }
        public int InsurerId { get; set; }
        public bool ShowOutcome { get; set; }

        public virtual InsuranceCompany Insurer { get; set; } = null!;
        public virtual ValidationOutcome Outcome { get; set; } = null!;
    }
}
