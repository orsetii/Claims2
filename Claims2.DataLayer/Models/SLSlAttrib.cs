using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SLSlAttrib
    {
        public int SSlAttribId { get; set; }
        public int? SSlId { get; set; }
        public int? SAttribId { get; set; }
        public int? SSlAttribSignificance { get; set; }
    }
}
