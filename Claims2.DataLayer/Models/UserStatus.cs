using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class UserStatus
    {
        public UserStatus()
        {
            User2s = new HashSet<User2>();
        }

        public int Id { get; set; }
        public string Status { get; set; } = null!;

        public virtual ICollection<User2> User2s { get; set; }
    }
}
