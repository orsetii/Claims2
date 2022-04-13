using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class CCompliment
    {
        public int ComplimentId { get; set; }
        public int ClaimId { get; set; }
        public string ReceivedBy { get; set; } = null!;
        public string ComplimentSource { get; set; } = null!;
        public string? ComplimentType { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string? ComplimentDetails { get; set; }
        public string? HandlerOne { get; set; }
        public string? HandlerTwo { get; set; }

        public virtual InsuranceClaim1 Claim { get; set; } = null!;
    }
}
