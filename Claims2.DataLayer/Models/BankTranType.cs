using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class BankTranType
    {
        public int BttId { get; set; }
        /// <summary>
        /// eg Cheque, DDR, BACS receipt, etc
        /// </summary>
        public string BttName { get; set; } = null!;
        /// <summary>
        /// Payment or Banking
        /// </summary>
        public string BttPb { get; set; } = null!;
        /// <summary>
        /// If true, show grouped totals for bank rec
        /// </summary>
        public bool BttTotalByGroup { get; set; }
        /// <summary>
        /// Order to present list
        /// </summary>
        public int BttOrder { get; set; }
        public int? BttCreatedBy { get; set; }
        public DateTime? BttCreatedOn { get; set; }
        public int? BttEditedBy { get; set; }
        public DateTime? BttEditedOn { get; set; }
    }
}
