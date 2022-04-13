using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class LoginHistory
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime? Date { get; set; }

        public virtual User2 User { get; set; } = null!;
    }
}
