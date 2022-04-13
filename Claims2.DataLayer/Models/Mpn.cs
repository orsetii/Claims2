using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Mpn
    {
        public int Id { get; set; }
        public long ItemId { get; set; }
        public string Mpn1 { get; set; } = null!;

        public virtual Item Item { get; set; } = null!;
    }
}
