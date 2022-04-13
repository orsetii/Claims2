using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class IStatusSlHistory1
    {
        public int IStatusSlHistId { get; set; }
        public int IStatusSlHistClaimId { get; set; }
        public int IStatusSlHistStatusId { get; set; }
        public DateTime? IStatusSlHistDate { get; set; }
        public int? IStatusSlHistUserId { get; set; }
    }
}
