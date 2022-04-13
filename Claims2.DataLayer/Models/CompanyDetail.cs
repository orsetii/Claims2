using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class CompanyDetail
    {
        public int CoId { get; set; }
        public string CoVatRegNo { get; set; } = null!;
    }
}
