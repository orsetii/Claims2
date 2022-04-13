using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class User
    {
        public int UsrId { get; set; }
        public string UsrName { get; set; } = null!;
        public string UsrWindowsLogin { get; set; } = null!;
        public int UsrAccessSales { get; set; }
        public int UsrAccessPurchases { get; set; }
        public int UsrAccessNominal { get; set; }
        public int UsrAccessAdmin { get; set; }
        public string? UsrEmail { get; set; }
        public int UsrAccessSl { get; set; }
        public int UsrAccessBl { get; set; }
        public int UsrAccessMi { get; set; }
    }
}
