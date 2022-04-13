using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class NcTblBiType
    {
        public NcTblBiType()
        {
            NcTblBiDescriptions = new HashSet<NcTblBiDescription>();
        }

        public int BiTypeId { get; set; }
        public string? BiTypeDescription { get; set; }

        public virtual ICollection<NcTblBiDescription> NcTblBiDescriptions { get; set; }
    }
}
