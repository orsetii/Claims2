using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class StStockTransaction
    {
        public int StStId { get; set; }
        public int StStTypeId { get; set; }
        public int StStSrId { get; set; }
        public int? StStAmount { get; set; }
        public DateTime StStDate { get; set; }
        public int? StStClaimId { get; set; }
        public int? StStUsrId { get; set; }

        public virtual StStockRecord StStSr { get; set; } = null!;
        public virtual StTransactionType StStType { get; set; } = null!;
    }
}
