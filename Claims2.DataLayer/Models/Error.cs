using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Error
    {
        public int Id { get; set; }
        public int? Ponumber { get; set; }
        public string Error1 { get; set; } = null!;
        public DateTime DateCreated { get; set; }
    }
}
