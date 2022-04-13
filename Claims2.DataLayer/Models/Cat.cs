using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Cat
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Path { get; set; } = null!;
        public long Itemid { get; set; }

        public virtual Item Item { get; set; } = null!;
    }
}
