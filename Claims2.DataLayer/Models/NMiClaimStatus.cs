using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class NMiClaimStatus
    {
        public string? AccountRef { get; set; }
        public int IStatusSlHistId { get; set; }
        public int IStatusSlHistClaimId { get; set; }
        public int IStatusSlHistStatusId { get; set; }
        public DateTime? IStatusSlHistDate { get; set; }
        public int? IStatusSlHistUserId { get; set; }
        public string UserName { get; set; } = null!;
        public string? Ntlogon { get; set; }
        public int? StatusSublevelId { get; set; }
        public string ISSlTypeName { get; set; } = null!;
        public bool ISSlTypeCloses { get; set; }
        public string CurrentStatus { get; set; } = null!;
    }
}
