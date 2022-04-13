using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class TempProductId
    {
        public int OldProductId { get; set; }
        public int NewProductId { get; set; }
        public DateTime Date { get; set; }
    }
}
