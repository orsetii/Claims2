using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class UserUserGroup
    {
        public int UugId { get; set; }
        public int UugUserId { get; set; }
        public int UugGroupId { get; set; }
    }
}
