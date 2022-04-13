using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ActionProfile
    {
        public ActionProfile()
        {
            ActionProfileDetails = new HashSet<ActionProfileDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int ActionId { get; set; }
        public int? InsuranceCompanyId { get; set; }
        public bool Important { get; set; }
        public bool Anti { get; set; }

        public virtual Action Action { get; set; } = null!;
        public virtual InsuranceCompany? InsuranceCompany { get; set; }
        public virtual ICollection<ActionProfileDetail> ActionProfileDetails { get; set; }
    }
}
