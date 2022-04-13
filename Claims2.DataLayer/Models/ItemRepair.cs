using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ItemRepair
    {
        public int Id { get; set; }
        public int InspectionId { get; set; }
        public int Action { get; set; }
        public string? Comment { get; set; }
        public bool? Repaired { get; set; }
        public DateTime? DateReported { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual ItemInspection Inspection { get; set; } = null!;
    }
}
