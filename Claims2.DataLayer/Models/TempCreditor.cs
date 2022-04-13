using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class TempCreditor
    {
        public int CrId { get; set; }
        public int CrSupplierId { get; set; }
        public int CrOhsId { get; set; }
        public string? CrName { get; set; }
        public string CrTranType { get; set; } = null!;
        public DateTime CrDate { get; set; }
        public string CrInvNo { get; set; } = null!;
        public decimal CrBalance { get; set; }
    }
}
