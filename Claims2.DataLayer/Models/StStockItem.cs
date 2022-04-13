using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class StStockItem
    {
        public StStockItem()
        {
            StAttribVals = new HashSet<StAttribVal>();
            StStockRecords = new HashSet<StStockRecord>();
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

        public virtual StManufacturer StSiMan { get; set; } = null!;
        public virtual StItemSpecification? StSiSpec { get; set; }
        public virtual ICollection<StAttribVal> StAttribVals { get; set; }
        public virtual ICollection<StStockRecord> StStockRecords { get; set; }
    }
}
