using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class BastionPop
    {
        public int PopId { get; set; }
        public string Guid { get; set; } = null!;
        public string PopUrl { get; set; } = null!;
        public DateTime PopDate { get; set; }
    }
}
