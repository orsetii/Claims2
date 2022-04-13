using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class DuckCreekAccount
    {
        public int Id { get; set; }
        public string AccountName { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public Guid Guid { get; set; }
        public string? Apiaddress { get; set; }
        public string? TokenEndpoint { get; set; }
    }
}
