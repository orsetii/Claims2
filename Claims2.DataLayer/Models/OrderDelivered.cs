using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OrderDelivered
    {
        public int Id { get; set; }
        public string SupplierName { get; set; } = null!;
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string CourierName { get; set; } = null!;
        public DateTime DeliveryTime { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
