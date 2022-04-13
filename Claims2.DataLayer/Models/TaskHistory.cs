using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class TaskHistory
    {
        public TaskHistory()
        {
            InsuranceClaim1s = new HashSet<InsuranceClaim1>();
        }

        public int Id { get; set; }
        public int InsuranceClaimId { get; set; }
        public string Text { get; set; } = null!;
        /// <summary>
        /// Due date - The date this task is due
        /// </summary>
        public DateTime Date { get; set; }
        public string Type { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; } = null!;
        public bool IsPersistent { get; set; }
        public int ActionId { get; set; }
        public bool Complete { get; set; }
        public DateTime? DateCompleted { get; set; }
        public string? User { get; set; }
        public int Allowedhours { get; set; }
        public int? ItemTaskHistoryId { get; set; }
        public int? OutcomeOptions { get; set; }
        public string? UserControlContextId { get; set; }
        public int? UserId { get; set; }
        public bool? Authorised { get; set; }
        public string? AuthorisedBy { get; set; }
        public DateTime? AuthorisedDate { get; set; }
        public string? AuthoriseRequestedBy { get; set; }
        public DateTime? AuthoriseRequestedDate { get; set; }
        public string? AuthorisationNote { get; set; }
        public bool? ChaseTask { get; set; }
        public int? AssignedToId { get; set; }
        public string? AssignedTo { get; set; }
        public bool PinnedTask { get; set; }

        public virtual Action Action { get; set; } = null!;
        public virtual InsuranceClaim1 InsuranceClaim { get; set; } = null!;
        public virtual ItemTaskHistory? ItemTaskHistory { get; set; }
        public virtual ClaimActionOutcome? OutcomeOptionsNavigation { get; set; }
        public virtual User2? UserNavigation { get; set; }
        public virtual ICollection<InsuranceClaim1> InsuranceClaim1s { get; set; }
    }
}
