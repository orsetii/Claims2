using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class EmailScrap
    {
        public int Id { get; set; }
        public int EmailId { get; set; }
        public string? EmailAddress { get; set; }
        public string? PolicyHolderName { get; set; }
        public string? HomePhone { get; set; }
        public string? PolicyExcess { get; set; }
        public string? PolicyHolderEmail { get; set; }
        public string? Address { get; set; }
        public string? PostCode { get; set; }
        public string? WorkPhone { get; set; }
        public string? Mobile { get; set; }
        public string? InstructionText { get; set; }
        public string? Description { get; set; }
    }
}
