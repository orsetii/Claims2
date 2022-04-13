using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldIStatusSlHistory
    {
        public int IStatusSlHistId { get; set; }
        public int IStatusSlHistClaimId { get; set; }
        public int IStatusSlHistStatusId { get; set; }
        public DateTime? IStatusSlHistDate { get; set; }
        public int? IStatusSlHistUserId { get; set; }
    }
}
