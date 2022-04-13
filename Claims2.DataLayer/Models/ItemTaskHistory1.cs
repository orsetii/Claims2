using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ItemTaskHistory1
    {
        public int Id { get; set; }
        public int ClaimItemId { get; set; }
        public string? Text { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; } = null!;
        public bool IsPersistent { get; set; }
        public int ActionId { get; set; }
        public bool Complete { get; set; }
        public DateTime? DateCompleted { get; set; }
    }
}
