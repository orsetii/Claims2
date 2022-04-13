using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldSPortalUser
    {
        public int UserIndex { get; set; }
        public int? Userid { get; set; }
        public string? Username { get; set; }
        public string? Userpassword { get; set; }
        public string? Usertype { get; set; }
        public string? LongName { get; set; }
    }
}
