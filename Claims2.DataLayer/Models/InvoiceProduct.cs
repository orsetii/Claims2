using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class InvoiceProduct
    {
        public int Id { get; set; }
        public int Invoiceid { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; } = null!;
        public double DeliveryPrice { get; set; }
        public DateTime DateCreated { get; set; }
        public double Vat { get; set; }

        public virtual Invoice1 Invoice { get; set; } = null!;
    }
}
