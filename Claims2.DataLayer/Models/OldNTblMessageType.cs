using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldNTblMessageType
    {
        public int MsgTypeId { get; set; }
        public string? MsgType { get; set; }
        public string? MsgTypeFrom { get; set; }
        public bool? MsgNeedsReply { get; set; }
    }
}
