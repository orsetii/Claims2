using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class QSla5
    {
        public int InsuranceClaimId { get; set; }
        public string? AccountRef { get; set; }
        public DateTime? Tfr { get; set; }
        public DateTime? Tto { get; set; }
        public int? Timelapse { get; set; }
    }
}
