using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OutcomeSupplier
    {
        public int Id { get; set; }
        public int OutcomeId { get; set; }
        public int SupplierId { get; set; }
        public bool ShowOutcome { get; set; }

        public virtual ValidationOutcome Outcome { get; set; } = null!;
        public virtual Supplier1 Supplier { get; set; } = null!;
    }
}
