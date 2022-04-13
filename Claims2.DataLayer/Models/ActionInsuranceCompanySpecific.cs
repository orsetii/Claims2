using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ActionInsuranceCompanySpecific
    {
        public int Id { get; set; }
        public int ActionId { get; set; }
        public int InsuranceCompanyId { get; set; }
        public int DeadlineInHours { get; set; }

        public virtual Action Action { get; set; } = null!;
        public virtual InsuranceCompany InsuranceCompany { get; set; } = null!;
    }
}
