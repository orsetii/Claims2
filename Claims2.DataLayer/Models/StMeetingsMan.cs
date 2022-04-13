using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class StMeetingsMan
    {
        public int StMeetingsManId { get; set; }
        public string? StMeetingsManText { get; set; }
        public DateTime? StMeetingsManDate { get; set; }
        public int StMeetingsManManId { get; set; }
        public bool StMeetingsManArchived { get; set; }

        public virtual StManufacturer StMeetingsManMan { get; set; } = null!;
    }
}
