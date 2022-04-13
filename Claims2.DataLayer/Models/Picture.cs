using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Picture
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public byte[]? Small { get; set; }
        public byte[]? Medium { get; set; }
        public byte[]? Large { get; set; }
        public string Mime { get; set; } = null!;
    }
}
