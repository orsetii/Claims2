using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class UserRole1
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int UserId { get; set; }

        public virtual Role1 Role { get; set; } = null!;
        public virtual User2 User { get; set; } = null!;
    }
}
