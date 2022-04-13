using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Markup
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int CategoryId { get; set; }
        public double Markup1 { get; set; }
        public string? Description { get; set; }
        public int InsuranceCompanyId { get; set; }
        public double PriceFromRetail { get; set; }
    }
}
