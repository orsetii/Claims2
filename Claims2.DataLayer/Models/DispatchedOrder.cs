using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class DispatchedOrder
    {
        public int Id { get; set; }
        public string SupplierName { get; set; } = null!;
        public int Ponumber { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DispatchDate { get; set; }
        public string CourierConsignmentNumber { get; set; } = null!;
        public string CourierContactNumber { get; set; } = null!;
        public DateTime DateCreated { get; set; }
    }
}
