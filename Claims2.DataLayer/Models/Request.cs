using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Request
    {
        public int Id { get; set; }
        public string Response { get; set; } = null!;
    }
}
