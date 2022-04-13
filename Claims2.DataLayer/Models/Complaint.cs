using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Complaint
    {
        public int ComplaintId { get; set; }
        public int ClaimId { get; set; }
        public string? Complainant { get; set; }
        public int ComplaintType { get; set; }
        public bool? ComplaintJustified { get; set; }
    }
}
