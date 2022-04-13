using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class GemValMapping
    {
        public int Id { get; set; }
        public int FnolvalueId { get; set; }
        public int GemValId { get; set; }
        public decimal SpecificGravity { get; set; }

        public virtual Value1 Fnolvalue { get; set; } = null!;
    }
}
