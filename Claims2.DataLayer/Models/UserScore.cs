using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class UserScore
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime MonthStarting { get; set; }
        public int Score { get; set; }

        public virtual User2 User { get; set; } = null!;
    }
}
