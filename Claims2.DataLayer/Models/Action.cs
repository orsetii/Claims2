using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Action
    {
        public Action()
        {
            ActionHistories = new HashSet<ActionHistory>();
            ActionInsuranceCompanySpecifics = new HashSet<ActionInsuranceCompanySpecific>();
            ActionProfiles = new HashSet<ActionProfile>();
            ClaimActionOutcomes = new HashSet<ClaimActionOutcome>();
            ItemActionHistories = new HashSet<ItemActionHistory>();
            ItemTaskHistories = new HashSet<ItemTaskHistory>();
            NextActionNextActionNavigations = new HashSet<NextAction>();
            NextActionPrevActions = new HashSet<NextAction>();
            TaskHistories = new HashSet<TaskHistory>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Deadline { get; set; }
        public int? PhaseId { get; set; }
        public bool Required { get; set; }
        public int? PreRequisiteActionId { get; set; }
        public bool IsPersistent { get; set; }
        public bool LogOnceOnly { get; set; }
        public string? TaskString { get; set; }
        public bool ClosingAction { get; set; }
        public bool? CreatesTask { get; set; }
        public bool EmailAlertTask { get; set; }
        public string? Laalias { get; set; }
        public int? ParentId { get; set; }
        public double? HoursToComplete { get; set; }
        /// <summary>
        /// 1 = Claim Level, 0 = Claim Item Level
        /// </summary>
        public bool? ClaimLevel { get; set; }
        /// <summary>
        /// No further actions for this item.
        /// </summary>
        public bool ItemComplete { get; set; }
        public string UserControl { get; set; } = null!;
        public int? DocumentId { get; set; }
        public int Order { get; set; }
        public string? LarouteName { get; set; }
        public bool Darequired { get; set; }
        public string? EmailTemplate { get; set; }
        public string? LloydsAlias { get; set; }
        public int? TreeId { get; set; }
        public bool PausingAction { get; set; }
        public bool FollowUpTask { get; set; }
        public string? AllianzAlias { get; set; }

        public virtual ICollection<ActionHistory> ActionHistories { get; set; }
        public virtual ICollection<ActionInsuranceCompanySpecific> ActionInsuranceCompanySpecifics { get; set; }
        public virtual ICollection<ActionProfile> ActionProfiles { get; set; }
        public virtual ICollection<ClaimActionOutcome> ClaimActionOutcomes { get; set; }
        public virtual ICollection<ItemActionHistory> ItemActionHistories { get; set; }
        public virtual ICollection<ItemTaskHistory> ItemTaskHistories { get; set; }
        public virtual ICollection<NextAction> NextActionNextActionNavigations { get; set; }
        public virtual ICollection<NextAction> NextActionPrevActions { get; set; }
        public virtual ICollection<TaskHistory> TaskHistories { get; set; }
    }
}
