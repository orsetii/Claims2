using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class LoginAttempt
    {
        public int Id { get; set; }
        public string ClaimId { get; set; } = null!;
        public string Postcode { get; set; } = null!;
        public string Ipaddress { get; set; } = null!;
        public bool ValidLogin { get; set; }
        public DateTime AttemptTime { get; set; }
    }
}
