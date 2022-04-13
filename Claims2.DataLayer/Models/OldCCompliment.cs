using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldCCompliment
    {
        public int ComplimentId { get; set; }
        public int ClaimId { get; set; }
        public string ReceivedBy { get; set; } = null!;
        public string ComplimentType { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string? ComplimentDetails { get; set; }
    }
}
