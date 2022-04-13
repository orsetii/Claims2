using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldStItemSpecification
    {
        public OldStItemSpecification()
        {
            OldStStockItems = new HashSet<OldStStockItem>();
        }

        public int StIsId { get; set; }
        public string StIsSpec { get; set; } = null!;

        public virtual ICollection<OldStStockItem> OldStStockItems { get; set; }
    }
}
