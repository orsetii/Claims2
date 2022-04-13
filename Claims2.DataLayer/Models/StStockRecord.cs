using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class StStockRecord
    {
        public StStockRecord()
        {
            StSrQuantities = new HashSet<StSrQuantity>();
            StStockTransactions = new HashSet<StStockTransaction>();
        }

        public int StSrId { get; set; }
        public int StSrSupplierId { get; set; }
        public int StSrStockItemId { get; set; }
        public int StSrQuantity { get; set; }
        public decimal StSrUnitPrice { get; set; }
        public decimal? StSrDiscountedPrice { get; set; }
        public decimal? StSrAdditionalDiscount { get; set; }
        public decimal StSrValidPrice { get; set; }
        public DateTime StSrDate { get; set; }
        public bool StSrClosed { get; set; }

        public virtual StStockItem StSrStockItem { get; set; } = null!;
        public virtual StSupplier StSrSupplier { get; set; } = null!;
        public virtual ICollection<StSrQuantity> StSrQuantities { get; set; }
        public virtual ICollection<StStockTransaction> StStockTransactions { get; set; }
    }
}
