using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Group
    {
        public Group()
        {
            UserGroup1s = new HashSet<UserGroup1>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int TeamleaderId { get; set; }

        public virtual User2 Teamleader { get; set; } = null!;
        public virtual ICollection<UserGroup1> UserGroup1s { get; set; }
    }
}
