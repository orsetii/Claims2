using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldStStockTransaction
    {
        public int StStId { get; set; }
        public int StStTypeId { get; set; }
        public int StStSrId { get; set; }
        public int? StStAmount { get; set; }
        public DateTime StStDate { get; set; }
        public int? StStClaimId { get; set; }
        public int? StStUsrId { get; set; }

        public virtual OldStStockRecord StStSr { get; set; } = null!;
        public virtual OldStTransactionType StStType { get; set; } = null!;
    }
}
