using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class DiamondCombination
    {
        public int Id { get; set; }
        public int CutId { get; set; }
        public decimal CaratFrom { get; set; }
        public decimal CaratTo { get; set; }
        public int ColourId { get; set; }
    }
}
