using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Access
    {
        public int AccessId { get; set; }
        public string UserName { get; set; } = null!;
        public DateTime DateTime { get; set; }
        public string Dns { get; set; } = null!;
        public string Ip { get; set; } = null!;
    }
}
