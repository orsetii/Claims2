using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class StTransactionType
    {
        public StTransactionType()
        {
            StStockTransactions = new HashSet<StStockTransaction>();
        }

        public int StStTypeId { get; set; }
        public string StStTypeText { get; set; } = null!;

        public virtual ICollection<StStockTransaction> StStockTransactions { get; set; }
    }
}
