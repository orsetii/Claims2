using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OrderAccepted
    {
        public int Id { get; set; }
        public bool PriceCorrect { get; set; }
        public bool Stock { get; set; }
        public bool DeliveryDate { get; set; }
        public int Ponumber { get; set; }
        public string SupplierName { get; set; } = null!;
        public DateTime DateCreated { get; set; }
    }
}
