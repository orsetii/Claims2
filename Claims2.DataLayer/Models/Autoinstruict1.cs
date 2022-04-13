using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Autoinstruict1
    {
        public int FnolImportId { get; set; }
        public int? FnolImportSetupId { get; set; }
        public string? SourceFile { get; set; }
        public string? TargetFile { get; set; }
        public string? ProcessText { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public byte[]? AttachedDoc { get; set; }
        public string? UserId { get; set; }
        public int? InstructionId { get; set; }
        public string? Comment { get; set; }
        public int Expr1 { get; set; }
    }
}
