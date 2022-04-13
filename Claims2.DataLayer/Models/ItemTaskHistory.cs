using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ItemTaskHistory
    {
        public ItemTaskHistory()
        {
            TaskHistories = new HashSet<TaskHistory>();
        }

        public int Id { get; set; }
        /// <summary>
        /// The item that this task relates to
        /// </summary>
        public int ClaimItemId { get; set; }
        /// <summary>
        /// The test description of this task
        /// </summary>
        public string? Text { get; set; }
        /// <summary>
        /// The date this task was generated
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// A task can be &apos;Workflow&apos; - generated automatically from an action, or &apos;Adhoc&apos;
        /// </summary>
        public string Type { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; } = null!;
        /// <summary>
        /// A persistent task is only fulfilled by a specific action against this item. That actions CompletingActionID must match this tasks ActionID
        /// </summary>
        public bool IsPersistent { get; set; }
        /// <summary>
        /// The ID for the action that generated this task
        /// </summary>
        public int ActionId { get; set; }
        /// <summary>
        /// Is this task complete? Non-persistent tasks will be fulfilled the moment a new task is created
        /// </summary>
        public bool Complete { get; set; }
        /// <summary>
        /// The date this task was completed
        /// </summary>
        public DateTime? DateCompleted { get; set; }
        public string? User { get; set; }
        public int Allowedhours { get; set; }
        public int? OutcomeOptions { get; set; }

        public virtual Action Action { get; set; } = null!;
        public virtual ClaimItem ClaimItem { get; set; } = null!;
        public virtual ClaimActionOutcome? OutcomeOptionsNavigation { get; set; }
        public virtual ICollection<TaskHistory> TaskHistories { get; set; }
    }
}
