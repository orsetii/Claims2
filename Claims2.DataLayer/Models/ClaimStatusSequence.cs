using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ClaimStatusSequence
    {
        public int ClaimStatusSequenceId { get; set; }
        public int FromStatusId { get; set; }
        public int ToStatusId { get; set; }
        public int SortSequence { get; set; }
    }
}
