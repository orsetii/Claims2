using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Scenario
    {
        public int Id { get; set; }
        public int? CommodityId { get; set; }
        public int? PerilId { get; set; }
        public bool? Technical { get; set; }
        public int YellowScore { get; set; }
        public int RedScore { get; set; }
    }
}
