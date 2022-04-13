using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class QDailyRep
    {
        public double? Clreplace { get; set; }
        public double? Clrepair { get; set; }
        public double? Clinspections { get; set; }
        public double? Clexcess { get; set; }
        public double? Clbetterment { get; set; }
        public double? Clcarriage { get; set; }
        public string? ClgroupBy { get; set; }
    }
}
