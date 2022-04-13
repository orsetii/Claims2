using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class DiamondCost
    {
        public int Id { get; set; }
        public int DiamondCombinationId { get; set; }
        public int DiamondQualityId { get; set; }
        public decimal Price { get; set; }
    }
}
