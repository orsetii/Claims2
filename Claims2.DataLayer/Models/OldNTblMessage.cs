using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldNTblMessage
    {
        public int MsgId { get; set; }
        public int MsgFrom { get; set; }
        public int MsgTo { get; set; }
        public DateTime MsgSent { get; set; }
        public DateTime? MsgRead { get; set; }
        public DateTime? MsgComplete { get; set; }
        public string? MsgTitle { get; set; }
        public string? MsgText { get; set; }
        public int? MsgClaimId { get; set; }
        public int? MsgThread { get; set; }
        public int? MsgType { get; set; }
        public int? Msgoutcome { get; set; }
        public bool? MsgArchive { get; set; }
        public bool Alerted { get; set; }
    }
}
