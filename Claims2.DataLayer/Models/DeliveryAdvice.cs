using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class DeliveryAdvice
    {
        public DeliveryAdvice()
        {
            Item1s = new HashSet<Item1>();
        }

        public int DeliveryAdviceId { get; set; }
        public string? VendorCode { get; set; }
        public string DeliveryReference { get; set; } = null!;
        public int DeliveryCompanyId { get; set; }
        public int CustomerId { get; set; }
        public string? ClientReference { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int InspectionTypeId { get; set; }
        public string Status { get; set; } = null!;
        public int ItemCount { get; set; }
        public bool Finalise { get; set; }
        public DateTime? FinaliseDate { get; set; }
        public string? FinaliseBy { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public int? InsuranceCompanyId { get; set; }
        public string? Comments { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual DeliveryCompany DeliveryCompany { get; set; } = null!;
        public virtual ICollection<Item1> Item1s { get; set; }
    }
}
