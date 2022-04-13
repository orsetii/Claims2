using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class FlooringAiimage
    {
        public int Id { get; set; }
        public int ClaimId { get; set; }
        public int DocumentId { get; set; }
        public string DocumentName { get; set; } = null!;
        public string FlooringType { get; set; } = null!;
        public bool Selected { get; set; }
    }
}
