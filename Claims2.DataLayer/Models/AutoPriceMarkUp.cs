using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class AutoPriceMarkUp
    {
        public int ApuId { get; set; }
        public int ApuInsuranceCoId { get; set; }
        public int ApuCommodityId { get; set; }
        public decimal ApuMarkUp { get; set; }
    }
}
