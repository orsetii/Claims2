using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class History
    {
        public int Id { get; set; }
        public int ValidationUserId { get; set; }
        public DateTime DateTime { get; set; }
        public string HistoryType { get; set; } = null!;
    }
}
