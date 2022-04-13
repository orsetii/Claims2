using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class FlagUpdate
    {
        public int Id { get; set; }
        public bool? DoUpdate { get; set; }
    }
}
