using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ItemActionHistory
    {
        public int Id { get; set; }
        public int ClaimItemId { get; set; }
        public DateTime Date { get; set; }
        public int? ActionId { get; set; }
        public string? User { get; set; }
        public int? ActionOrder { get; set; }
        public int? OutcomeOptionsId { get; set; }

        public virtual Action? Action { get; set; }
        public virtual ClaimItem ClaimItem { get; set; } = null!;
        public virtual ClaimActionOutcome? OutcomeOptions { get; set; }
    }
}
