using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldPbcatedt
    {
        public string PbeName { get; set; } = null!;
        public string? PbeEdit { get; set; }
        public short PbeType { get; set; }
        public int? PbeCntr { get; set; }
        public short PbeSeqn { get; set; }
        public int? PbeFlag { get; set; }
        public string? PbeWork { get; set; }
    }
}
