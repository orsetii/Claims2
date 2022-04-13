using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class CustomerInvoice
    {
        public int Sbsref { get; set; }
        public decimal? PolicyExcess { get; set; }
        public decimal? Betterment { get; set; }
        public bool IsPhvatregistered { get; set; }
        public string? AccountRef { get; set; }
        public string? Name { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string? Address4 { get; set; }
        public string? Address5 { get; set; }
        public string? Operator { get; set; }
        public string Laref { get; set; } = null!;
        public decimal CarriageToInsurance { get; set; }
        public string? LaaccountRef { get; set; }
        public string? Laname { get; set; }
        public string? Laadress1 { get; set; }
        public string? Laadress2 { get; set; }
        public string? Laadress3 { get; set; }
        public string? Laadress4 { get; set; }
        public string? Laadress5 { get; set; }
    }
}
