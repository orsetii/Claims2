using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class UserCommodity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CommodityId { get; set; }
        public int Score { get; set; }

        public virtual Value1 Commodity { get; set; } = null!;
        public virtual User2 User { get; set; } = null!;
    }
}
