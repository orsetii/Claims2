using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ActionTreeCommodity
    {
        public int Id { get; set; }
        public int Fnolvalueid { get; set; }
        public int ActionTreeId { get; set; }

        public virtual ActionTree ActionTree { get; set; } = null!;
    }
}
