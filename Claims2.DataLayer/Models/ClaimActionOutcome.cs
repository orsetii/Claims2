using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ClaimActionOutcome
    {
        public ClaimActionOutcome()
        {
            ActionHistories = new HashSet<ActionHistory>();
            ItemActionHistories = new HashSet<ItemActionHistory>();
            ItemTaskHistories = new HashSet<ItemTaskHistory>();
            TaskHistories = new HashSet<TaskHistory>();
        }

        public int Id { get; set; }
        /// <summary>
        /// A comma separated list of suggested actions to move to.
        /// </summary>
        public string OutcomeOptions { get; set; } = null!;
        /// <summary>
        /// The ID of the action that the user has decided to move onto.
        /// </summary>
        public int? ChosenOutcome { get; set; }

        public virtual Action? ChosenOutcomeNavigation { get; set; }
        public virtual ICollection<ActionHistory> ActionHistories { get; set; }
        public virtual ICollection<ItemActionHistory> ItemActionHistories { get; set; }
        public virtual ICollection<ItemTaskHistory> ItemTaskHistories { get; set; }
        public virtual ICollection<TaskHistory> TaskHistories { get; set; }
    }
}
