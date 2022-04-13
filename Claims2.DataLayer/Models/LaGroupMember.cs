using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class LaGroupMember
    {
        public int GmId { get; set; }
        public int? GmLaId { get; set; }
        public int? GmGnId { get; set; }
    }
}
