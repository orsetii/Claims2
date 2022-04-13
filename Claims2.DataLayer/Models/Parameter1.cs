using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Parameter1
    {
        public Parameter1()
        {
            ActionProfileDetails = new HashSet<ActionProfileDetail>();
            ClaimItemValues = new HashSet<ClaimItemValue>();
            ClaimValues = new HashSet<ClaimValue>();
            ValidationClaimItemValues = new HashSet<ValidationClaimItemValue>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? ParentParameterId { get; set; }
        public bool Required { get; set; }
        public bool? LookUpParameter { get; set; }
        public bool ClaimLevel { get; set; }
        public int SortOrder { get; set; }
        public string? Phalias { get; set; }

        public virtual ICollection<ActionProfileDetail> ActionProfileDetails { get; set; }
        public virtual ICollection<ClaimItemValue> ClaimItemValues { get; set; }
        public virtual ICollection<ClaimValue> ClaimValues { get; set; }
        public virtual ICollection<ValidationClaimItemValue> ValidationClaimItemValues { get; set; }
    }
}
