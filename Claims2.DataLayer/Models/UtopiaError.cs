using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class UtopiaError
    {
        public int ErrorId { get; set; }
        public int ClaimId { get; set; }
        public string ErrorMessage { get; set; } = null!;
        public DateTime ErrorDate { get; set; }
    }
}
