using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class NTblCustomerAttitude
    {
        public int CaId { get; set; }
        public int CaClaimId { get; set; }
        public bool? CaInformedNextSteps { get; set; }
        public bool? CaEvasive { get; set; }
        public bool? CaHostile { get; set; }
        public bool? CaPushy { get; set; }
        public bool? CaQuestionableCircumstances { get; set; }
        public bool? CaUnsatisfactoryDocumentation { get; set; }
        public bool? CaOtherConcerns { get; set; }
        public string? CaConcernDetails { get; set; }
        public bool? CaProductUnderYear { get; set; }
        public string? CaSubstantiation { get; set; }
    }
}
