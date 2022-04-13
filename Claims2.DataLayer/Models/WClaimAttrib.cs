using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class WClaimAttrib
    {
        public int WCaId { get; set; }
        public int WCaClaimId { get; set; }
        public int WCaAttribId { get; set; }
        public string? WCaAttribVal { get; set; }
    }
}
