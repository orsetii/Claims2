using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class PolicyHolder
    {
        public int PhId { get; set; }
        public string? PhCompanyName { get; set; }
        public string? PhTitle { get; set; }
        public string? PhFirstName { get; set; }
        public string? PhSurName { get; set; }
        public string? PhAddr1 { get; set; }
        public string? PhAddr2 { get; set; }
        public string? PhAddr3 { get; set; }
        public string? PhAddr4 { get; set; }
        public string? PhPostCode { get; set; }
        public string? PhTelHome { get; set; }
        public string? PhTelWork { get; set; }
        public string? PhTelMobile { get; set; }
        public string? PhEmail { get; set; }
        public int? PhCreatedBy { get; set; }
        public DateTime? PhCreatedOn { get; set; }
        public int? PhEditedBy { get; set; }
        public DateTime? PhEditedOn { get; set; }
    }
}
