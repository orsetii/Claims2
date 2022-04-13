using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ActionTree
    {
        public ActionTree()
        {
            ActionTreeCommodities = new HashSet<ActionTreeCommodity>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<ActionTreeCommodity> ActionTreeCommodities { get; set; }
    }
}
