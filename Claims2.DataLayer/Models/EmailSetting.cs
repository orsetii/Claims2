using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class EmailSetting
    {
        public int EmsId { get; set; }
        public string? EmsBccAccount { get; set; }
        public string? EmsPoMessage { get; set; }
        public string? EmsCancelMessage { get; set; }
        public string? EmsSmtpMailserver { get; set; }
        public string? EmsDocFolder { get; set; }
        public string? EmsClaimsDocFolder { get; set; }
        public string? EmsGoodsSupplierEmail { get; set; }
        public string? EmsFpEmailFromAccount { get; set; }
        public string? EmsFpBccAccountStandard { get; set; }
        public string? EmsFpBccAccountExceptions { get; set; }
        public string? EmsNewPoMessage { get; set; }
        public string? EmsNewPoRevisedMessage { get; set; }
        public string? EmsFromAccountSms { get; set; }
        public string? EmsNewPoConfirmationMessage { get; set; }
        public string? EmsNewSmsMessage { get; set; }
        public string? EmsNewPolicyholderEmailMessage { get; set; }
        public string? EmsSmsRelayCo { get; set; }
        public string? EmsNewPoChaseUpMessage { get; set; }
        public string? EmsClaimWindowUrl { get; set; }
        public string? EmsNewPhFollowUpSms { get; set; }
    }
}
