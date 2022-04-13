using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ValidationSavedMatch
    {
        public int Smid { get; set; }
        public string? Postcode { get; set; }
        public string? ClaimRef { get; set; }
        public int OriginalProductId { get; set; }
        public int ReplacementProductId { get; set; }
        public double Match { get; set; }
        public string UserName { get; set; } = null!;
        public DateTime DateSaved { get; set; }
        public int? OriginalItemId { get; set; }
        public int? ReplacementItemId { get; set; }
    }
}
