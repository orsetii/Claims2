using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class StSrQuantity
    {
        public int StSqId { get; set; }
        public int StSqSrId { get; set; }
        public int StSqAvailable { get; set; }
        public int StSqReserved { get; set; }
        public int StSqSold { get; set; }

        public virtual StStockRecord StSqSr { get; set; } = null!;
    }
}
