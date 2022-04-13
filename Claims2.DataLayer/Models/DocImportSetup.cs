using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class DocImportSetup
    {
        public int FnolImportSetupId { get; set; }
        public string? InsuranceCompany { get; set; }
        public int? InsuranceCompanyId { get; set; }
        public int? LossAdjusterId { get; set; }
        public string? DocSource { get; set; }
        public string? DocTarget { get; set; }
        public string? DocError { get; set; }
        public string? DefaultDocType { get; set; }
        public string? FromEmail { get; set; }
        public string? ConfirmEmail { get; set; }
        public int? MinimumHours { get; set; }
        public DateTime? LastSent { get; set; }
    }
}
