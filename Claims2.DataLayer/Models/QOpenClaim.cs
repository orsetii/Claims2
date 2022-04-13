using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class QOpenClaim
    {
        public int Clid { get; set; }
        public string? Bmonth { get; set; }
        public bool Clclosed { get; set; }
        public string? Claccref { get; set; }
        public string Clstatus { get; set; } = null!;
        public string? Tclid { get; set; }
    }
}
