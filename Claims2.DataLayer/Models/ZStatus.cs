using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ZStatus
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; } = null!;
        public bool Closed { get; set; }
    }
}
