using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class BadWord
    {
        public int Id { get; set; }
        public string BadWords { get; set; } = null!;
    }
}
