using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class GemClarity
    {
        public int Id { get; set; }
        public int GemId { get; set; }
        public int ClarityId { get; set; }

        public virtual Value1 Clarity { get; set; } = null!;
        public virtual Value1 Gem { get; set; } = null!;
    }
}
