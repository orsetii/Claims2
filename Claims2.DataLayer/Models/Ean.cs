using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Ean
    {
        public int Id { get; set; }
        public string Ean1 { get; set; } = null!;
        public long Itemid { get; set; }

        public virtual Item Item { get; set; } = null!;
    }
}
