using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class GpDetailNew
    {
        public int GpdId { get; set; }
        public DateTime GpdDate { get; set; }
        public DateTime? GpdOriginalDate { get; set; }
        public int GpdClaimId { get; set; }
        public string? GpdRef { get; set; }
        public int GpdSourceCode { get; set; }
        public string? GpdSourceName { get; set; }
        public decimal GpdNet { get; set; }
        public DateTime? GpdMiProfitDate { get; set; }
    }
}
