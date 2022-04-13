using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Item
    {
        public Item()
        {
            BasicData = new HashSet<BasicDatum>();
            CatItems = new HashSet<CatItem>();
            Cats = new HashSet<Cat>();
            Eans = new HashSet<Ean>();
            Mpns = new HashSet<Mpn>();
            Upcs = new HashSet<Upc>();
        }

        public long Id { get; set; }
        public string? ItemBrand { get; set; }
        public string? ItemFeatures { get; set; }
        public string? ItemPartNumber { get; set; }
        public string? ItemPackageQuantity { get; set; }

        public virtual ICollection<BasicDatum> BasicData { get; set; }
        public virtual ICollection<CatItem> CatItems { get; set; }
        public virtual ICollection<Cat> Cats { get; set; }
        public virtual ICollection<Ean> Eans { get; set; }
        public virtual ICollection<Mpn> Mpns { get; set; }
        public virtual ICollection<Upc> Upcs { get; set; }
    }
}
