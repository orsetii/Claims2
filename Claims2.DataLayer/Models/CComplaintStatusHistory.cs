using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class CComplaintStatusHistory
    {
        public int ComplaintStatusHistoryId { get; set; }
        public int ComplaintId { get; set; }
        public int? PreviousStatusId { get; set; }
        public int NewStatusId { get; set; }
        public DateTime Date { get; set; }
        public string DoneBy { get; set; } = null!;
    }
}
