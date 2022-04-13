using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class RolePath
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int PathId { get; set; }

        public virtual Path Path { get; set; } = null!;
        public virtual Role1 Role { get; set; } = null!;
    }
}
