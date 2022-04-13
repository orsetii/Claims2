using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class DeliveryAdviceItem
    {
        public int DeliveryAdviceItemId { get; set; }
        public int DeliveryAdviceId { get; set; }
        public string? VendorCode { get; set; }
        public int? ItemId { get; set; }
        public string? ItemNumber { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string? ItemDescription { get; set; }
        public bool Quarantine { get; set; }
        public DateTime? QuarantineFromDate { get; set; }
        public DateTime? QuarantineToDate { get; set; }
        public int QuarantineDays { get; set; }
        public bool Backup { get; set; }
        public DateTime? BackupRequestDate { get; set; }
        public string? BackupRequested { get; set; }
        public DateTime? BackupDate { get; set; }
        public string? BackupComments { get; set; }
        public string? Status { get; set; }
        public bool DeliveryToCustomer { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public bool GoodsReceived { get; set; }
        public DateTime? GoodsReceivedDate { get; set; }
    }
}
