using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SupplierFamilyDetail
    {
        public int Id { get; set; }
        public int FamilyId { get; set; }
        public int SupplierId { get; set; }
        public double DeliveryCost { get; set; }
        public double InstallationCost { get; set; }
    }
}
