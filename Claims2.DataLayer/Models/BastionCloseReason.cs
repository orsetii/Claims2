using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class BastionCloseReason
    {
        public int Id { get; set; }
        public string Reason { get; set; } = null!;
    }
}
