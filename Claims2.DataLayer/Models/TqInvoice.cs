using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class TqInvoice
    {
        public string? Tclid { get; set; }
        public string Clstatus { get; set; } = null!;
        public string? Bdate { get; set; }
        public string? Bmonth { get; set; }
    }
}
