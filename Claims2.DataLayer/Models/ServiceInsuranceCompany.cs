using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ServiceInsuranceCompany
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int InsuranceCompanyId { get; set; }
        public decimal Price { get; set; }
        public int? LossAdjusterId { get; set; }
        public bool Anti { get; set; }
    }
}
