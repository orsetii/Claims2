using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class MessageProduct
    {
        public int Id { get; set; }
        public int? Productid { get; set; }
        public string? PolicyName { get; set; }
        public string? Address { get; set; }
        public string? PostalCode { get; set; }
        public string? Laref { get; set; }
        public double? Excess { get; set; }
        public int? SingleArticleLimit { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public double? Price { get; set; }
        public int Messageid { get; set; }
        public DateTime? DateCreated { get; set; }
        public string? BarCodeType { get; set; }
        public bool? BarCodeScanned { get; set; }
        public string? BarCodeData { get; set; }
        public string? ProductDescription { get; set; }
        public string? MessageType { get; set; }
        public string? Width { get; set; }
        public string? Length { get; set; }
        public string? RoomType { get; set; }
        public bool? VatRegistered { get; set; }
        public bool? CashSettled { get; set; }
        public int? AppProductId { get; set; }
        public int? OrigionalProductId { get; set; }
        public string? Insurer { get; set; }
        public string? JewelleryType { get; set; }

        public virtual Message Message { get; set; } = null!;
    }
}
