using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Upc
    {
        public int Id { get; set; }
        public long Itemid { get; set; }
        public string Upc1 { get; set; } = null!;

        public virtual Item Item { get; set; } = null!;
    }
}
