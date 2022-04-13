using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class UserOnline
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Status { get; set; }
        public DateTime DateTime { get; set; }
    }
}
