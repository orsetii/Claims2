using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ClaimStatusType
    {
        public int CstId { get; set; }
        public int CstCode { get; set; }
        public string? CstDescription { get; set; }
    }
}
