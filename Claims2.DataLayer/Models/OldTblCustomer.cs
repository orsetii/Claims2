using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldTblCustomer
    {
        public OldTblCustomer()
        {
            OldTblDeliveryAdvices = new HashSet<OldTblDeliveryAdvice>();
        }

        public int CustomerId { get; set; }
        public string? VendorCode { get; set; }
        public string? TitleName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string? Town { get; set; }
        public string? County { get; set; }
        public string? Postcode { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? DateModified { get; set; }

        public virtual ICollection<OldTblDeliveryAdvice> OldTblDeliveryAdvices { get; set; }
    }
}
