using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class PoNewStatus
    {
        public int PonsId { get; set; }
        public int PonsStatusCode { get; set; }
        public string PonsStatusName { get; set; } = null!;
    }
}
