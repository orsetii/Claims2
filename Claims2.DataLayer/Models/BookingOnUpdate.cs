using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class BookingOnUpdate
    {
        public int BouId { get; set; }
        public string Subject { get; set; } = null!;
        public string EmailFrom { get; set; } = null!;
        public string EmailTo { get; set; } = null!;
        public DateTime EmailDate { get; set; }
        public int? ClaimId { get; set; }
        public string? Lareference { get; set; }
        public int? PrevActionId { get; set; }
    }
}
