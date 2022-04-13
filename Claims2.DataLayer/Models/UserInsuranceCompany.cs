using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class UserInsuranceCompany
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int InsuranceCompanyId { get; set; }

        public virtual InsuranceCompany InsuranceCompany { get; set; } = null!;
        public virtual User2 User { get; set; } = null!;
    }
}
