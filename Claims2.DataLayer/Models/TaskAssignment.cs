using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class TaskAssignment
    {
        public int Id { get; set; }
        public int AssignedTo { get; set; }
        public int AssignedBy { get; set; }
        public int TaskHistoryId { get; set; }
    }
}
