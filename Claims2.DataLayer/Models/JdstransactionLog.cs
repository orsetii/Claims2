using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class JdstransactionLog
    {
        public int Id { get; set; }
        public string Message { get; set; } = null!;
        public DateTime DateCreated { get; set; }
    }
}
