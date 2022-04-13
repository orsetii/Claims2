using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SAllItem1
    {
        public int SClaimItemId { get; set; }
        public int? SClaimorderid { get; set; }
        public int? SInsuranceclaimid { get; set; }
        public int? SProductid { get; set; }
        public int? SSupplierid { get; set; }
        public int? SItemtypeid { get; set; }
        public string? SCreatedby { get; set; }
        public DateTime? SCreatedon { get; set; }
    }
}
