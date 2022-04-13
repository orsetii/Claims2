using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldMiCause
    {
        public int MiCauseId { get; set; }
        public string? MiCauseDesc { get; set; }
        public int? CauseTypeId { get; set; }
        public int? SubCauseTypeId { get; set; }
    }
}
