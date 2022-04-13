using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class StatusHistory
    {
        public int Id { get; set; }
        public int InspectionId { get; set; }
        public int StatusId { get; set; }
        public DateTime Date { get; set; }
        public string? Comment { get; set; }
    }
}
