using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Email
    {
        public int Id { get; set; }
        public string Body { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public string From { get; set; } = null!;
        public string To { get; set; } = null!;
        public string? Cc { get; set; }
        public DateTime Recived { get; set; }
        public int? InsuranceClaimId { get; set; }
        public bool Read { get; set; }
        public string Emailid { get; set; } = null!;
        public bool FromFnol { get; set; }
        public bool Dismissed { get; set; }
        public string? WorkspaceBody { get; set; }
        public bool? Epdq { get; set; }
    }
}
