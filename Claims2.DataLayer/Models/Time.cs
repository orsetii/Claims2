using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Time
    {
        public int? Insuranceclaimid { get; set; }
        public string? Consignment { get; set; }
        public DateTime? InstructionRecieved { get; set; }
        public DateTime? BookedOn { get; set; }
        public double? Sla58 { get; set; }
        public double? IncomingCallsIns { get; set; }
        public double? IncomingCallsPh { get; set; }
        public double? OutgoingCallsIns { get; set; }
        public double? OutGoingCallsPh { get; set; }
    }
}
