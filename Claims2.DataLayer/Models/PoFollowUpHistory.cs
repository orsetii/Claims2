using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class PoFollowUpHistory
    {
        public int PfhId { get; set; }
        public int PfhType { get; set; }
        public int PfhPomId { get; set; }
        public string? PfhText { get; set; }
    }
}
