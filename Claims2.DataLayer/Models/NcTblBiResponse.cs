using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class NcTblBiResponse
    {
        public int BiResponseId { get; set; }
        public int? InsuranceClaimId { get; set; }
        public int? BiDescriptionId { get; set; }
        public int? BiOptionId { get; set; }
        public int? BiScore { get; set; }
    }
}
