using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class InspectionImage
    {
        public int Id { get; set; }
        public int InspectionId { get; set; }
        public byte[] Thumbnail { get; set; } = null!;
        public byte[] Image { get; set; } = null!;

        public virtual ItemInspection Inspection { get; set; } = null!;
    }
}
