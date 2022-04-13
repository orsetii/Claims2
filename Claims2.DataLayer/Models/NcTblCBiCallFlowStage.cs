using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class NcTblCBiCallFlowStage
    {
        public int CallFlowRelId { get; set; }
        public int? CallFlowStageId { get; set; }
        public string? CallFlowStage { get; set; }
        public int? BiTypeId { get; set; }
        public int? CallFlowStageOrder { get; set; }
        public string? CallFlowText { get; set; }
        public int CallFlowTypeId { get; set; }
    }
}
