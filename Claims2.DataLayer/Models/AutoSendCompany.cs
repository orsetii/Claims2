using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class AutoSendCompany
    {
        public int AutoSendId { get; set; }
        public int InsuranceCompanyId { get; set; }
        public bool AutoSend { get; set; }
        public string? EmailAddress { get; set; }
    }
}
