using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class BastionSberequest
    {
        public int SbeId { get; set; }
        public string? ClaimId { get; set; }
        public string SbeStatus { get; set; } = null!;
        public bool SbeSent { get; set; }
        public double MaximumPrice { get; set; }
        public DateTime? SentDate { get; set; }
        public string? ReceivedDate { get; set; }
    }
}
