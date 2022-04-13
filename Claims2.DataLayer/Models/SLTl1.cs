using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SLTl1
    {
        public SLTl1()
        {
            StManufacturers = new HashSet<StManufacturer>();
        }

        public int STlId { get; set; }
        public string? STlDesc { get; set; }

        public virtual ICollection<StManufacturer> StManufacturers { get; set; }
    }
}
