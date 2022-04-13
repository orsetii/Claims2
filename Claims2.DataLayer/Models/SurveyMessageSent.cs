using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SurveyMessageSent
    {
        public int Id { get; set; }
        public int InsuranceClaimId { get; set; }
    }
}
