using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class DataAlert
    {
        public int Id { get; set; }
        public int ClaimId { get; set; }
        public int Data28Status { get; set; }
        public DateTime? Data28Time { get; set; }
        public int Data14Status { get; set; }
        public DateTime? Data14Time { get; set; }
    }
}
