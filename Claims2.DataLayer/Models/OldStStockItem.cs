using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldStStockItem
    {
        public OldStStockItem()
        {
            OldStAttribVals = new HashSet<OldStAttribVal>();
            OldStStockRecords = new HashSet<OldStStockRecord>();
        }

        public int StSiId { get; set; }
        public int StSiSlId { get; set; }
        public int StSiManId { get; set; }
        public string? StSiModelNo { get; set; }
        public string? StSiSkuNo { get; set; }
        public int? StSiSpecId { get; set; }
        public string? StSiImage { get; set; }
        public string? StSiExtraInfo { get; set; }
        public int? StSiSageCode { get; set; }

        public virtual OldStManufacturer StSiMan { get; set; } = null!;
        public virtual OldStItemSpecification? StSiSpec { get; set; }
        public virtual ICollection<OldStAttribVal> OldStAttribVals { get; set; }
        public virtual ICollection<OldStStockRecord> OldStStockRecords { get; set; }
    }
}
