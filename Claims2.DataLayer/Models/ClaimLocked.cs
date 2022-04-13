using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ClaimLocked
    {
        public int Id { get; set; }
        public int ClaimId { get; set; }
        public DateTime LockTime { get; set; }
    }
}
