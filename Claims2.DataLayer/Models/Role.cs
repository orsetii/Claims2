using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; } = null!;
        public string RoleKey { get; set; } = null!;
    }
}
