using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class InsuranceCompanyType
    {
        public int TypeId { get; set; }
        public string Description { get; set; } = null!;
    }
}
