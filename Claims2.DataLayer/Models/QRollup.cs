using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class QRollup
    {
        public int Clid { get; set; }
        public string? Claccref { get; set; }
        public string Clusr { get; set; } = null!;
        public string Cltype { get; set; } = null!;
        public string? Clitem { get; set; }
        public string Clstatus { get; set; } = null!;
        public string? Bmonth { get; set; }
        public string? Bdate { get; set; }
        public string? Tclid { get; set; }
        public bool Clclosed { get; set; }
        public int ISSlTypeId { get; set; }
        public int LossAdjusterId { get; set; }
    }
}
