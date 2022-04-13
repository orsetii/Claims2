using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class CarpetrightVoucher
    {
        public int? OrderId { get; set; }
        public DateTime? Created { get; set; }
        public string? Hash { get; set; }
        public string? Phemail { get; set; }
        public int? ClaimId { get; set; }
    }
}
