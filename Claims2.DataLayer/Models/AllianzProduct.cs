using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class AllianzProduct
    {
        public int Id { get; set; }
        public string AllianzProductCode { get; set; } = null!;
        public int? SbsproductCode { get; set; }
        public string AllianzDescription { get; set; } = null!;
        public string? Sbsdescription { get; set; }
    }
}
