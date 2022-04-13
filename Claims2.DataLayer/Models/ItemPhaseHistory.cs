using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ItemPhaseHistory
    {
        public int Id { get; set; }
        public int ClaimItemId { get; set; }
        public int PhaseId { get; set; }
        public DateTime Date { get; set; }
        public string User { get; set; } = null!;

        public virtual Phase Phase { get; set; } = null!;
    }
}
