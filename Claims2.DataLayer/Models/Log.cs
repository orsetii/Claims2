using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Log
    {
        public int LogId { get; set; }
        public DateTime? EventTime { get; set; }
        public string? StackTrace { get; set; }
        public string? ExceptionMessage { get; set; }
        public string? AdditionalComments { get; set; }
        public int? UserId { get; set; }
    }
}
