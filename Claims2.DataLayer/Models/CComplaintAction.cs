using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class CComplaintAction
    {
        public int ComplaintActionId { get; set; }
        public int ComplaintId { get; set; }
        public int ActionTypeId { get; set; }
        public string? Text { get; set; }
        public DateTime Date { get; set; }
        public int CreatedById { get; set; }
    }
}
