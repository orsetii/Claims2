using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class CommentReason
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string ThirdParty { get; set; } = null!;
        public bool AwaitingDecision { get; set; }
        public string? LloydsMialias { get; set; }
    }
}
