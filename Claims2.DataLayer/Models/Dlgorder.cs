using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Dlgorder
    {
        public int Id { get; set; }
        public int InsuranceClaimid { get; set; }
        public string RowType { get; set; } = null!;
        public int? SmartLiftOrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string? InvoiceSalutation { get; set; }
        public string? InvoiceForename { get; set; }
        public string? InvoiceSurname { get; set; }
        public string? InvoiceCompanyName { get; set; }
        public string? InvoiceAddress1 { get; set; }
        public string? InvoiceAddress2 { get; set; }
        public string? InvoiceAddress3 { get; set; }
        public string? InvoiceAddress4 { get; set; }
        public string? InvoiceAddress5 { get; set; }
        public string? InvoicePostcode { get; set; }
        public string? InvoiceCountry { get; set; }
        public string? InvoiceEmailAddress { get; set; }
        public string? InvoiceTelephone { get; set; }
        public string? InvoiceMobile { get; set; }
        public string? InvoiceFax { get; set; }
        public string? ProductSku { get; set; }
        public string? ProductName { get; set; }
        public double? ProductPrice { get; set; }
        public int? Quantity { get; set; }
        public string? Status { get; set; }
        public string? DeliverySalutation { get; set; }
        public string? DeliveryForename { get; set; }
        public string? DeliverySurname { get; set; }
        public string? DeliveryCompanyName { get; set; }
        public string? DeliveryAddress1 { get; set; }
        public string? DeliveryAddress2 { get; set; }
        public string? DeliveryAddress3 { get; set; }
        public string? DeliveryAddress4 { get; set; }
        public string? DeliveryAddress5 { get; set; }
        public string? DeliveryPostcode { get; set; }
        public string? DeliveryCountry { get; set; }
        public string? DeliveyEmailAddress { get; set; }
        public string? DeliveryTelephone { get; set; }
        public string? DeliveryMobile { get; set; }
        public string? DeliveryFax { get; set; }
        public string? DeliveryInstructions { get; set; }
        public double? OrderLineSubtotal { get; set; }
        public double? DiscountTotal { get; set; }
        public double? DeliveryCharge { get; set; }
        public double? OrderTotal { get; set; }
        public double? Vattotal { get; set; }
        public string? VendorTxcode { get; set; }
        public string? PayerId { get; set; }
        public string? PayerEmail { get; set; }
        public string? PayerStatus { get; set; }
        public string? PayerAddressStatus { get; set; }
        public string? MerchantProtectionEligibility { get; set; }
        public string? _3dstatus { get; set; }
        public string? AddressVerificationResult { get; set; }
        public string? PostcodeVerificationResult { get; set; }
        public string? Cv2verificationResult { get; set; }
        public string? AvsandCv2result { get; set; }
        public string? _3rdManResult { get; set; }
        public string? Action { get; set; }
        public string? Shipping { get; set; }
        public string? AmazonOrderId { get; set; }
        public DateTime? OrderSentDateTime { get; set; }
        public bool? OrderSent { get; set; }
    }
}
