using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class UserSession
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public Guid ServiceSession { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual User3 User { get; set; } = null!;
    }
}
