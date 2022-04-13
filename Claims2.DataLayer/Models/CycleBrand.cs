using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class CycleBrand
    {
        public CycleBrand()
        {
            Cycles = new HashSet<Cycle>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Cycle> Cycles { get; set; }
    }
}
