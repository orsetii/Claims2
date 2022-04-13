using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldStStockRecord
    {
        public OldStStockRecord()
        {
            OldStSrQuantities = new HashSet<OldStSrQuantity>();
            OldStStockTransactions = new HashSet<OldStStockTransaction>();
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

        public virtual OldStStockItem StSrStockItem { get; set; } = null!;
        public virtual OldStSupplier StSrSupplier { get; set; } = null!;
        public virtual ICollection<OldStSrQuantity> OldStSrQuantities { get; set; }
        public virtual ICollection<OldStStockTransaction> OldStStockTransactions { get; set; }
    }
}
