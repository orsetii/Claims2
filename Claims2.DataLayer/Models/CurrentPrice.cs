using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class CurrentPrice
    {
        public int Id { get; set; }
        public int CommodityId { get; set; }
        public decimal PricePerTroyOz { get; set; }
        public DateTime? DateTaken { get; set; }
    }
}
