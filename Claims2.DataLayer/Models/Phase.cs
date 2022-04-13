using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Phase
    {
        public Phase()
        {
            ItemPhaseHistories = new HashSet<ItemPhaseHistory>();
            PhaseHistories = new HashSet<PhaseHistory>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        /// <summary>
        /// Level 1 - This is a claim phase, Level 2 - This is an item phase
        /// </summary>
        public int Level { get; set; }
        public int Order { get; set; }
        public string? ConfirmationText { get; set; }
        public string? PhaseDescription { get; set; }
        public int? PreRequisitePhaseId { get; set; }
        public string? CustomerAlias { get; set; }

        public virtual ICollection<ItemPhaseHistory> ItemPhaseHistories { get; set; }
        public virtual ICollection<PhaseHistory> PhaseHistories { get; set; }
    }
}
