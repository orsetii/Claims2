using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class UserTimekeeping
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Day { get; set; }
        public bool OnTime { get; set; }

        public virtual User2 User { get; set; } = null!;
    }
}
