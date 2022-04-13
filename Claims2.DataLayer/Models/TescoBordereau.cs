using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class TescoBordereau
    {
        public int AbId { get; set; }
        public int AbSimId { get; set; }
        public int AbBcId { get; set; }
        public decimal AbGross { get; set; }
        public int? AbSidId { get; set; }
    }
}
