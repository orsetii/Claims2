using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class AccountAcustomisation
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int AttributeId { get; set; }
        public int FamilyId { get; set; }
        public double Weighting { get; set; }
        public int FilterOrder { get; set; }
        public string FilterType { get; set; } = null!;
    }
}
