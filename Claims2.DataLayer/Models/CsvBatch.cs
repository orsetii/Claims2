using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class CsvBatch
    {
        public int CbId { get; set; }
        public int CbNextBatchId { get; set; }
    }
}
