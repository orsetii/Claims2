using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class QBookedMonth
    {
        public int Clid { get; set; }
        public string? Tclid { get; set; }
        public int IStatusSlHistStatusId { get; set; }
        public string? BDate { get; set; }
    }
}
