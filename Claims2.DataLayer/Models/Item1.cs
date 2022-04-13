using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Item1
    {
        public Item1()
        {
            ItemParts = new HashSet<ItemPart>();
            ItemStatusHistory1s = new HashSet<ItemStatusHistory1>();
        }

        public int ItemId { get; set; }
        public string? ItemNumber { get; set; }
        public string? VendorCode { get; set; }
        public string? ContractReference { get; set; }
        public string? ConsignmentReference { get; set; }
        public string? ClientReference { get; set; }
        public string? DeliveryReference { get; set; }
        public int? ItemTypeId { get; set; }
        public string? ItemTypeDescription { get; set; }
        public int? StockConditionId { get; set; }
        public string? StockConditionDescription { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public bool IsProduct { get; set; }
        public string? ProductCode { get; set; }
        public string? Status { get; set; }
        public string? Comments { get; set; }
        public string? Notes { get; set; }
        public string? InspectionReference { get; set; }
        public string? InspectionStatus { get; set; }
        public int? InspectionStatusId { get; set; }
        public string? StatusComments { get; set; }
        public DateTime? StatusDate { get; set; }
        public string? InspectionDetails { get; set; }
        public int? DeliverAdviceId { get; set; }
        public int? DeliveryAdviceItemId { get; set; }
        public bool Finalise { get; set; }
        public DateTime? FinaliseDate { get; set; }
        public string? FinaliseBy { get; set; }
        public string? BuyerTitleName { get; set; }
        public string? BuyerName { get; set; }
        public string? BuyerAddress1 { get; set; }
        public string? BuyerAddress2 { get; set; }
        public string? BuyerAddress3 { get; set; }
        public string? BuyerTown { get; set; }
        public string? BuyerCounty { get; set; }
        public string? BuyerPostcode { get; set; }
        public string? BuyerCountry { get; set; }
        public decimal SalesPrice { get; set; }
        public string? SalesChannel { get; set; }
        public string? SaleType { get; set; }
        public string? SalesComments { get; set; }
        public bool ItemSold { get; set; }
        public DateTime? SaleDate { get; set; }
        public DateTime? CustomerDeliveryDate { get; set; }
        public string? Warranty { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string? SalesRef { get; set; }
        public bool Notify { get; set; }
        public DateTime? NotifyDate { get; set; }
        public string? Tag { get; set; }

        public virtual DeliveryAdvice? DeliverAdvice { get; set; }
        public virtual ItemType? ItemType { get; set; }
        public virtual StockCondition? StockCondition { get; set; }
        public virtual ICollection<ItemPart> ItemParts { get; set; }
        public virtual ICollection<ItemStatusHistory1> ItemStatusHistory1s { get; set; }
    }
}
