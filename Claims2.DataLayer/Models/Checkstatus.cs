using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Checkstatus
    {
        public int SInspectionId { get; set; }
        public int? SInspItem { get; set; }
        public int? SStatus { get; set; }
    }
}
