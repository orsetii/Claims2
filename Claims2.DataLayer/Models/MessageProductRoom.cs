using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class MessageProductRoom
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int RoomId { get; set; }
        public string RoomType { get; set; } = null!;
        public string? Width { get; set; }
        public string? Length { get; set; }
    }
}
