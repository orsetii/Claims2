using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Invoice1
    {
        public Invoice1()
        {
            InvoiceProducts = new HashSet<InvoiceProduct>();
        }

        public int Id { get; set; }
        public int Insuranceclaimid { get; set; }
        public int Ponumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string InvoiceNumber { get; set; } = null!;
        public string CustomerName { get; set; } = null!;
        public string CustomerAddress { get; set; } = null!;
        public string CustomerContactNumber { get; set; } = null!;
        public string DeliveryName { get; set; } = null!;
        public string DeliveryAddress { get; set; } = null!;
        public string DeliveryContactNumber { get; set; } = null!;
        public double DeliveryPrice { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string SupplierName { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public int Invoiceid { get; set; }
        public bool Deleted { get; set; }
        public string? Explination { get; set; }
        public double DeliveryVat { get; set; }
        public double InvoiceTotal { get; set; }
        public double TotalVat { get; set; }

        public virtual ICollection<InvoiceProduct> InvoiceProducts { get; set; }
    }
}
