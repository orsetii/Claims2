using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class BastionError
    {
        public int ErrorId { get; set; }
        public string ErrorSection { get; set; } = null!;
        public string ExceptionDesc { get; set; } = null!;
        public string? Guid { get; set; }
        public DateTime ErrorDate { get; set; }
    }
}
