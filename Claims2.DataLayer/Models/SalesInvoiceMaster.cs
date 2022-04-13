using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SalesInvoiceMaster
    {
        public int SimId { get; set; }
        public int SimCustomerId { get; set; }
        public int SimInsCoId { get; set; }
        public DateTime? SimDate { get; set; }
        public int? SimAccountingPeriod { get; set; }
        public int SimClaimId { get; set; }
        public string? SimLareference { get; set; }
        public int SimClaimInvInstance { get; set; }
        public string SimInvType { get; set; } = null!;
        public string SimDocType { get; set; } = null!;
        public decimal SimExcess { get; set; }
        public decimal SimBetterment { get; set; }
        public decimal SimCarriage { get; set; }
        public bool SimAddVat { get; set; }
        public decimal? SimVat { get; set; }
        public bool SimPosted { get; set; }
        public string? SimInvoiceNo { get; set; }
        public string? SimWarning { get; set; }
        public string? SimComment { get; set; }
        public string? SimCommentInternal { get; set; }
        public string? SimPolicyNumber { get; set; }
        public int SimCarriageVrId { get; set; }
        public bool SimHideCarriage { get; set; }
        public bool SimHideExcess { get; set; }
        public bool SimHideBetterment { get; set; }
        public bool SimAutoVatCalc { get; set; }
        public int SimBettermentVrId { get; set; }
        public int? SimCreatedBy { get; set; }
        public DateTime? SimCreatedOn { get; set; }
        public int? SimEditedBy { get; set; }
        public DateTime? SimEditedOn { get; set; }
        public string? SimLvBType { get; set; }
        public decimal SimCarriageVat { get; set; }
        public decimal SimBettermentVat { get; set; }
    }
}
