using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldStTransactionType
    {
        public OldStTransactionType()
        {
            OldStStockTransactions = new HashSet<OldStStockTransaction>();
        }

        public int StStTypeId { get; set; }
        public string StStTypeText { get; set; } = null!;

        public virtual ICollection<OldStStockTransaction> OldStStockTransactions { get; set; }
    }
}
