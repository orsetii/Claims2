using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class StItemSpecification
    {
        public StItemSpecification()
        {
            StStockItems = new HashSet<StStockItem>();
        }

        public int StIsId { get; set; }
        public string StIsSpec { get; set; } = null!;

        public virtual ICollection<StStockItem> StStockItems { get; set; }
    }
}
