using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class TempMiChange
    {
        public int Id { get; set; }
        public string NewCattext { get; set; } = null!;
        public int NewCat { get; set; }
    }
}
