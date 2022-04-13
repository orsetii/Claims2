using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class AutoPriceMaster
    {
        public int ApmId { get; set; }
        public int ApmInsuranceCoId { get; set; }
        public decimal ApmDeliveryStandardMax { get; set; }
        public decimal ApmDefaultMarkUp { get; set; }
        public string? ApmContractDoc { get; set; }
        public string? ApmDeliveryDoc { get; set; }
    }
}
