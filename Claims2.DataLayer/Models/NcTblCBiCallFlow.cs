using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class NcTblCBiCallFlow
    {
        public int CallFlowId { get; set; }
        public int? CallFlowStageId { get; set; }
        public string? CallFlowText { get; set; }
        public int? CallFlowOrder { get; set; }
        public int? CallFlowTypeId { get; set; }
    }
}
