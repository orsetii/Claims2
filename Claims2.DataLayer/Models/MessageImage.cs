using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class MessageImage
    {
        public int Id { get; set; }
        public int MessageId { get; set; }
        public string ImageType { get; set; } = null!;
        public string MimeType { get; set; } = null!;
        public byte[] Image { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public string? RoomX { get; set; }
        public string? RoomY { get; set; }
        public int? ProductId { get; set; }
        public int? RoomId { get; set; }
        public string? MessageBody { get; set; }
    }
}
