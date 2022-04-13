using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Flooring
    {
        public Flooring()
        {
            FlooringColours = new HashSet<FlooringColour>();
        }

        public int FlFlooringId { get; set; }
        public string Name { get; set; } = null!;
        public int? SupplierId { get; set; }
        public string? Suitability { get; set; }
        public string? Description { get; set; }
        public string? PileContent { get; set; }
        public string? SupplierRefNo { get; set; }
        public decimal SbsCostPrice { get; set; }
        public decimal SrpIncVat { get; set; }
        public string? Brand { get; set; }
        public int? NoOfColours { get; set; }
        public int? SpId { get; set; }
        public decimal? FlooringWidth1 { get; set; }
        public decimal? FlooringWidth2 { get; set; }
        public decimal? FlooringWidth3 { get; set; }
        public decimal? FlooringWidth4 { get; set; }
        public decimal? FlooringWidth5 { get; set; }
        public decimal? Thickness { get; set; }
        public decimal? WearLayerMm { get; set; }
        public decimal? MetresPerPack { get; set; }
        public int? PacksPerPallet { get; set; }
        public string? Type { get; set; }
        public bool? Isvoucher { get; set; }
        public bool Disabled { get; set; }
        public DateTime? DisabledOn { get; set; }
        public bool Archived { get; set; }
        public int? Category { get; set; }
        public decimal? Weight { get; set; }

        public virtual FlooringCategory? CategoryNavigation { get; set; }
        public virtual Product1? Sp { get; set; }
        public virtual FlooringSupplier? Supplier { get; set; }
        public virtual ICollection<FlooringColour> FlooringColours { get; set; }
    }
}
