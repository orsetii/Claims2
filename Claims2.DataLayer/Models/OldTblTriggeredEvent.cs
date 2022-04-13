using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldTblTriggeredEvent
    {
        public int EventId { get; set; }
        public DateTime EventDate { get; set; }
        public int RecordId { get; set; }
        public string EventSource { get; set; } = null!;
    }
}
