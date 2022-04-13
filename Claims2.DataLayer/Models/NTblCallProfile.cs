using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class NTblCallProfile
    {
        public int CallProfId { get; set; }
        public int? Caller { get; set; }
        public int? CallType { get; set; }
        public int? Reason { get; set; }
        public int EventId { get; set; }
        public bool Open { get; set; }
    }
}
