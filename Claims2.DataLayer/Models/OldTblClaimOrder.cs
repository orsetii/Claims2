﻿using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldTblClaimOrder
    {
        public int ClaimOrderId { get; set; }
        /// <summary>
        /// &apos;AAA&apos;
        /// </summary>
        public string? VendorCode { get; set; }
        public int InsuranceClaimId { get; set; }
        public string ShortDescription { get; set; } = null!;
        public int ItemTypeId { get; set; }
        public int? ItemSubLevelId { get; set; }
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        public int OrderedQuantity { get; set; }
        public int CancelledQuantity { get; set; }
        public decimal BuyRate { get; set; }
        public decimal SellRate { get; set; }
        public decimal CarriageBuy { get; set; }
        public decimal CarriageSell { get; set; }
        public bool ApplyCarriage { get; set; }
        public bool Additional { get; set; }
        public string? SagePonumber { get; set; }
        public string? SageInvoiceNumber { get; set; }
        public bool? PoReq { get; set; }
        public DateTime? PoReqDate { get; set; }
        public int? PoReqRaisedBy { get; set; }
        public bool? PoSync { get; set; }
        public DateTime? PoSyncDate { get; set; }
        public bool? PoRaised { get; set; }
        public DateTime? PoRaisedDate { get; set; }
        public bool? PoVat { get; set; }
        public string? PoSage { get; set; }
        public bool? InvReq { get; set; }
        public DateTime? InvReqDate { get; set; }
        public int? InvReqRaisedBy { get; set; }
        public bool? InvSync { get; set; }
        public DateTime? InvSyncDate { get; set; }
        public bool? InvRaised { get; set; }
        public DateTime? InvRaisedDate { get; set; }
        public bool? InvVat { get; set; }
        public string? InvSage { get; set; }
        public bool? CreditReq { get; set; }
        public DateTime? CreditReqDate { get; set; }
        public bool? CreditSync { get; set; }
        public DateTime? CreditSyncDate { get; set; }
        public bool? CreditRaised { get; set; }
        public DateTime? CreditRaisedDate { get; set; }
        public bool? CreditVat { get; set; }
        public string? CreditSage { get; set; }
        public string? DetailedDescription1 { get; set; }
        public string? DetailedDescription2 { get; set; }
        public string? DetailedDescription3 { get; set; }
        public string? DetailedDescription4 { get; set; }
        public string? DetailedDescription5 { get; set; }
        public string? DetailedDescription6 { get; set; }
        public string? DetailedDescription7 { get; set; }
        public string? DetailedDescription8 { get; set; }
        public string? DetailedDescription9 { get; set; }
        public string? DetailedDescription10 { get; set; }
        public string? DetailedDescription11 { get; set; }
        public string? DetailedDescription12 { get; set; }
        public string? DetailedDescription13 { get; set; }
        public string? DetailedDescription14 { get; set; }
        public string? DetailedDescription15 { get; set; }
        public string? DetailedDescription16 { get; set; }
        public string? DetailedDescription17 { get; set; }
        public string? DetailedDescription18 { get; set; }
        public string? DetailedDescription19 { get; set; }
        public string? DetailedDescription20 { get; set; }
        public string? Tag { get; set; }
        public string? Comments { get; set; }
        public string Ipaddress { get; set; } = null!;
        public string CreatedBy { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public string ModifiedBy { get; set; } = null!;
        public DateTime DateModified { get; set; }
        /// <summary>
        /// If this field is 1, this claim order is for an unlisted item
        /// </summary>
        public bool SingleUseItem { get; set; }
        public int? StockTransactionId { get; set; }
        public DateTime? ExpectedDeliveryDate { get; set; }
        public DateTime? DateCancelled { get; set; }
        public int? CancelledBy { get; set; }
        public int? OriginalClaimItemId { get; set; }
        public int? InitiatingInspectionId { get; set; }
    }
}
