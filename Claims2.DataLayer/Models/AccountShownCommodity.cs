using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class AccountShownCommodity
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int CommodityId { get; set; }
    }
}
