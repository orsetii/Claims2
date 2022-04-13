using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class LittleJotter
    {
        public int Id { get; set; }
        public DateTime DueDate { get; set; }
        public bool Deleted { get; set; }
        public int ClaimId { get; set; }
        public string? ClaimNote { get; set; }
        public int UserId { get; set; }
    }
}
