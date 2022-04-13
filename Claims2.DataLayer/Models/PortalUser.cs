using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class PortalUser
    {
        public int PortalUserId { get; set; }
        public int? PortalUserType { get; set; }
        public string? PortalUserName { get; set; }
        public string? PortalUserPassword { get; set; }
        public bool? PortalUserActive { get; set; }
        public int? PortalUserAdmin { get; set; }
        public string? PortalUserDescription { get; set; }
        public DateTime? AddedOn { get; set; }
        public string? AddedBy { get; set; }
    }
}
