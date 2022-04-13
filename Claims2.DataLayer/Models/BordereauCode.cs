using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class BordereauCode
    {
        public int BcId { get; set; }
        public int BcInsCoId { get; set; }
        public string BcCode { get; set; } = null!;
        public string BcDescription { get; set; } = null!;
        public decimal? BcMarkup { get; set; }
    }
}
