using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Role1
    {
        public Role1()
        {
            RolePaths = new HashSet<RolePath>();
            UserRole1s = new HashSet<UserRole1>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<RolePath> RolePaths { get; set; }
        public virtual ICollection<UserRole1> UserRole1s { get; set; }
    }
}
