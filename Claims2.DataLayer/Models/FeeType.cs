using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class FeeType
    {
        public FeeType()
        {
            Fees = new HashSet<Fee>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Fee> Fees { get; set; }
    }
}
