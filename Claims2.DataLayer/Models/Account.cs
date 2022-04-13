using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Account
    {
        public int AccountId { get; set; }
        public string AccountName { get; set; } = null!;
        public string? AccountMailAddress { get; set; }
        public string? ConfirmationMailAddress { get; set; }
        public int? LossAdjusterId { get; set; }
        public int? InsuranceCompanyId { get; set; }
        public string? AllowedIp { get; set; }
        public string? AllowedIp2 { get; set; }
        public string? AllowedIp3 { get; set; }
        public string? AllowedIp4 { get; set; }
        public bool? HasDynamicAssessment { get; set; }
        public bool? HasInstructionPortal { get; set; }
        public bool? HasValidationPortal { get; set; }
        public string? Guid { get; set; }
        public bool HideSupplier { get; set; }
        public bool ShowCheapestOnly { get; set; }
        public bool ShowL4lfirst { get; set; }
        public bool ShowIncAndExVat { get; set; }
        public bool Show1ResultOnly { get; set; }
        public bool ShowTriage { get; set; }
        public bool RewordMatch { get; set; }
        public bool HasTriage { get; set; }
        public bool HasMultiItems { get; set; }
        public decimal? AuthLimit { get; set; }
        public bool ShowStockColumn { get; set; }
        public bool ShowTotalPriceColumn { get; set; }
        public bool ShowUnkownItemButton { get; set; }
        public bool ShowAlternativeUpgradeButton { get; set; }
        public bool? ShowBypassTriage { get; set; }
        public bool? ShowDowngrade { get; set; }
    }
}
