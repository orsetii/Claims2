using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Notification
    {
        public int Id { get; set; }
        public int ClaimId { get; set; }
        public string Text { get; set; } = null!;
        public int UserId { get; set; }
        public bool Read { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual InsuranceClaim1 Claim { get; set; } = null!;
        public virtual User2 User { get; set; } = null!;
    }
}
