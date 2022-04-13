using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class PoStatus
    {
        public int PosId { get; set; }
        public int PosStatusCode { get; set; }
        public string? PosStatusName { get; set; }
    }
}
