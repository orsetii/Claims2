using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class PostingMonth
    {
        public int PmId { get; set; }
        /// <summary>
        /// Jan 2000 = 1 (Jan 08 = 97)
        /// </summary>
        public int PmCurrent { get; set; }
        public int PmClosed { get; set; }
        public int PmLocked { get; set; }
        public int PmCurrentYearStart { get; set; }
        public int PmPriorYearStart { get; set; }
    }
}
