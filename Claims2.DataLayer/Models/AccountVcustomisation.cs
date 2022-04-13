using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class AccountVcustomisation
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int ValueId { get; set; }
        public int FamilyId { get; set; }
        public double Score { get; set; }
    }
}
