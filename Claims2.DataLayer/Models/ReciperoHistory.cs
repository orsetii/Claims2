using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ReciperoHistory
    {
        public int HistoryId { get; set; }
        public int ClaimId { get; set; }
        public DateTime? SearchDate { get; set; }
        public string? Insurer { get; set; }
        public string? ContactNumber { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
