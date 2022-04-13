using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Supplier1
    {
        public Supplier1()
        {
            Fitters = new HashSet<Fitter>();
            FlooringSuppliers = new HashSet<FlooringSupplier>();
            OutcomeSuppliers = new HashSet<OutcomeSupplier>();
            ServiceDays = new HashSet<ServiceDay>();
            SupplierFees = new HashSet<SupplierFee>();
            SupplierServices = new HashSet<SupplierService>();
        }

        public int SupplierId { get; set; }
        public string? VendorCode { get; set; }
        public string? AccountRef { get; set; }
        public string SupplierName { get; set; } = null!;
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string? Address4 { get; set; }
        public string? Address5 { get; set; }
        public string? PostCode { get; set; }
        public string CountryCode { get; set; } = null!;
        public string? Telephone { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? Website { get; set; }
        public string? Contact { get; set; }
        public string? VatregistrationNo { get; set; }
        public decimal Carriage { get; set; }
        public string? CompanyName { get; set; }
        public string? Tag { get; set; }
        public string? Comments { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public DateTime LastUpdated { get; set; }
        public bool? DisplayOnWeb { get; set; }
        public bool Deleted { get; set; }
        public string? EmailCc { get; set; }
        public bool AutoConfirmPo { get; set; }
        public bool FastTrackSupplier { get; set; }
        public string? AccountsNotes { get; set; }
        public bool NoPorequired { get; set; }
        public int AccountHandler { get; set; }
        public int PortalUser { get; set; }
        public decimal VoucherDiscount { get; set; }
        public bool? AllowSms { get; set; }
        public bool? Agrade { get; set; }

        public virtual ICollection<Fitter> Fitters { get; set; }
        public virtual ICollection<FlooringSupplier> FlooringSuppliers { get; set; }
        public virtual ICollection<OutcomeSupplier> OutcomeSuppliers { get; set; }
        public virtual ICollection<ServiceDay> ServiceDays { get; set; }
        public virtual ICollection<SupplierFee> SupplierFees { get; set; }
        public virtual ICollection<SupplierService> SupplierServices { get; set; }
    }
}
