using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ItemStatusHistory1
    {
        public int ItemStatusHistoryId { get; set; }
        public int ItemId { get; set; }
        public int InspectionStatusId { get; set; }
        public DateTime? StatusDate { get; set; }
        public string? StatusComments { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? DateModified { get; set; }

        public virtual Item1 Item { get; set; } = null!;
    }
}
