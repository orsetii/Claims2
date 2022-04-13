using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class UserGroup1
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int UserId { get; set; }

        public virtual Group Group { get; set; } = null!;
        public virtual User2 User { get; set; } = null!;
    }
}
