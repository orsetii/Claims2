using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ItemFinance
    {
        public int Id { get; set; }
        public int? ItemId { get; set; }
        public int ClaimId { get; set; }
        public int? FinanceTypeId { get; set; }
        public double? Net { get; set; }
        public double? Gross { get; set; }

        public virtual ClaimItem1? Item { get; set; }
    }
}
