using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class User3
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public bool? Enabled { get; set; }
        public int AccountId { get; set; }
        public int AccessLevel { get; set; }
        public Guid? ServiceSession { get; set; }
        public string? EmailAddress { get; set; }
        public bool? HasMidashboard { get; set; }
        public string? AgencyReference { get; set; }
    }
}
