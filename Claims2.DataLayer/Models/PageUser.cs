using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class PageUser
    {
        public int Id { get; set; }
        public string Url { get; set; } = null!;
        public int UserId { get; set; }
    }
}
