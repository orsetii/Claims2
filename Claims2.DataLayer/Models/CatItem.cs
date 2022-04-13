using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class CatItem
    {
        public long Id { get; set; }
        public long ItemId { get; set; }
        public long? MerchCatName { get; set; }
        public string? MerchCatPath { get; set; }

        public virtual Item Item { get; set; } = null!;
    }
}
