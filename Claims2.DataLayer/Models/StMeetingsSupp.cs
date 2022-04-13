using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class StMeetingsSupp
    {
        public int StMeetingsSuppId { get; set; }
        public string? StMeetingsSuppText { get; set; }
        public DateTime? StMeetingsSuppDate { get; set; }
        public int StMeetingsSuppSuppId { get; set; }
        public bool StMeetingsSuppArchived { get; set; }
    }
}
