using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class AllianzDevice
    {
        public int Id { get; set; }
        public string DeviceId { get; set; } = null!;
        public int? SbsclaimItemId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal PurchasePrice { get; set; }
        public string? Imei { get; set; }
    }
}
