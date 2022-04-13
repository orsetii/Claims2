using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Message
    {
        public Message()
        {
            MessageProducts = new HashSet<MessageProduct>();
        }

        public int Id { get; set; }
        public int? ClaimId { get; set; }
        public string? ProductDescription { get; set; }
        public string? BarCodeType { get; set; }
        public bool? BarCodeScanned { get; set; }
        public string? BarCodeData { get; set; }
        public string? CallBackMpn { get; set; }
        public DateTime? CallBackDateTime { get; set; }
        public string? MessageSubject { get; set; }
        public string? MessageType { get; set; }
        public bool Deleted { get; set; }
        public DateTime Datelogged { get; set; }
        public int? Productid { get; set; }
        public DateTime DateCreated { get; set; }
        public string? Message1 { get; set; }
        public string? Jsonmessage { get; set; }
        public string? PaymentTaken { get; set; }

        public virtual ICollection<MessageProduct> MessageProducts { get; set; }
    }
}
