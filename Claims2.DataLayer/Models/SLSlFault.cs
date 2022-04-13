using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SLSlFault
    {
        public int SSlFaultId { get; set; }
        public int? SSlId { get; set; }
        public int? SFaultTypeId { get; set; }
    }
}
