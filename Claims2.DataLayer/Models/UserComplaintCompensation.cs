using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class UserComplaintCompensation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Month { get; set; }
        public double Score { get; set; }

        public virtual User2 User { get; set; } = null!;
    }
}
