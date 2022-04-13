using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class NcTblCBiDescription
    {
        public int BiDescriptionId { get; set; }
        public int? BiTypeId { get; set; }
        public string? BiDescription { get; set; }
        public int? BiStageId { get; set; }
        public int? ImportedFrom { get; set; }
    }
}
