using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ItemStatusHistory
    {
        public int Id { get; set; }
        public int ClaimItemId { get; set; }
        public int StatusOrder { get; set; }
        public DateTime Date { get; set; }
    }
}
