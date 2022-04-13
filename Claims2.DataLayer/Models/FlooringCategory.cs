using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class FlooringCategory
    {
        public FlooringCategory()
        {
            Floorings = new HashSet<Flooring>();
        }

        public int FlCatId { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Flooring> Floorings { get; set; }
    }
}
