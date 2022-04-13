using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Message1
    {
        public int Id { get; set; }
        public string Messagebody { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public string MessageType { get; set; } = null!;
    }
}
