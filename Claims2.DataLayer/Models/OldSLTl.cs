using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldSLTl
    {
        public OldSLTl()
        {
            OldStManufacturers = new HashSet<OldStManufacturer>();
        }

        public int STlId { get; set; }
        public string? STlDesc { get; set; }

        public virtual ICollection<OldStManufacturer> OldStManufacturers { get; set; }
    }
}
