using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ErrorLog
    {
        public int ElId { get; set; }
        public DateTime ElDate { get; set; }
        public string? ElStoredProcedure { get; set; }
        public string? ElErrorMessage { get; set; }
    }
}
