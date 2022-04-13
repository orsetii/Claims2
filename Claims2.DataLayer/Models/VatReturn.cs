using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class VatReturn
    {
        public int VatId { get; set; }
        public int MonthStart { get; set; }
        public int MonthEnd { get; set; }
        public int PeriodYear { get; set; }
        public double Box1 { get; set; }
        public double Box2 { get; set; }
        public double Box3 { get; set; }
        public double Box4 { get; set; }
        public double Box5 { get; set; }
        public double Box6 { get; set; }
        public double Box7 { get; set; }
        public double Box8 { get; set; }
        public double Box9 { get; set; }
        public DateTime VatDate { get; set; }
        public int VatUser { get; set; }
        public bool Closed { get; set; }
        public DateTime? ClosedDate { get; set; }
        public int? ClosedUser { get; set; }
    }
}
