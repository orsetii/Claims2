using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Setting1
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int InsuranceCompanyId { get; set; }
        public bool BandBanding { get; set; }
        public bool BrandBanding { get; set; }
        public bool VoucherEnabled { get; set; }
        public string? ClaimIdformat { get; set; }
    }
}
