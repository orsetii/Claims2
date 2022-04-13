using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ValidationOutcome
    {
        public ValidationOutcome()
        {
            ClaimItem2s = new HashSet<ClaimItem2>();
            InverseParentOutcomeNavigation = new HashSet<ValidationOutcome>();
            OutcomeCommodities = new HashSet<OutcomeCommodity>();
            OutcomeInsurers = new HashSet<OutcomeInsurer>();
            OutcomeSuppliers = new HashSet<OutcomeSupplier>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? ParentOutcome { get; set; }
        public bool DefaultOutcomeCommodity { get; set; }
        public bool DefaultOutcomeInsurer { get; set; }
        public bool DefaultOutcomeSupplier { get; set; }

        public virtual ValidationOutcome? ParentOutcomeNavigation { get; set; }
        public virtual ICollection<ClaimItem2> ClaimItem2s { get; set; }
        public virtual ICollection<ValidationOutcome> InverseParentOutcomeNavigation { get; set; }
        public virtual ICollection<OutcomeCommodity> OutcomeCommodities { get; set; }
        public virtual ICollection<OutcomeInsurer> OutcomeInsurers { get; set; }
        public virtual ICollection<OutcomeSupplier> OutcomeSuppliers { get; set; }
    }
}
