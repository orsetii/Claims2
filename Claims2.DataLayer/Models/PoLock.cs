using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class PoLock
    {
        public int PolId { get; set; }
        public int PolUserId { get; set; }
        public DateTime PolTime { get; set; }
    }
}
