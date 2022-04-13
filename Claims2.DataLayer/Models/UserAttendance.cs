using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class UserAttendance
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public bool Absent { get; set; }
        public bool Late { get; set; }
        public int WorkingDays { get; set; }
    }
}
