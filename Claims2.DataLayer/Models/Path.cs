using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Path
    {
        public Path()
        {
            RolePaths = new HashSet<RolePath>();
        }

        public int Id { get; set; }
        public string Path1 { get; set; } = null!;

        public virtual ICollection<RolePath> RolePaths { get; set; }
    }
}
