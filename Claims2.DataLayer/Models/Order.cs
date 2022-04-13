using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public string? CustomerAddress1 { get; set; }
        public string? CustomerAddress2 { get; set; }
        public string? CustomerAddress4 { get; set; }
        public string? CustomerPostCode { get; set; }
        public string? CustomerContactNumber { get; set; }
        public string? CustomerName { get; set; }
        public string? DeliveryAddress1 { get; set; }
        public string? DeliveryAddress2 { get; set; }
        public string? DeliveryAddress4 { get; set; }
        public string? DeliveryPostCode { get; set; }
        public string? DeliveryContactNumber { get; set; }
        public string? DeliveryName { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public double? DeliveryPrice { get; set; }
        public DateTime? OrderDate { get; set; }
        public string? InvoiceNumber { get; set; }
        public int? PurchaseOrderNumber { get; set; }
        public string? SupplierName { get; set; }
        public string? ProductParentId { get; set; }
        public int? Sbsref { get; set; }
        public string? Guid { get; set; }
        public string? Success { get; set; }
        public DateTime? DateCreated { get; set; }
        public string? MessageSent { get; set; }
    }
}
