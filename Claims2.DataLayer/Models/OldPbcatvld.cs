using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldPbcatvld
    {
        public string PbvName { get; set; } = null!;
        public string PbvVald { get; set; } = null!;
        public short PbvType { get; set; }
        public int? PbvCntr { get; set; }
        public string? PbvMsg { get; set; }
    }
}
