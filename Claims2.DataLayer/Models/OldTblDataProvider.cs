using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldTblDataProvider
    {
        public int DataProviderId { get; set; }
        public string ShortDescription { get; set; } = null!;
        public int FrgRed { get; set; }
        public int FrgGreen { get; set; }
        public int FrgBlue { get; set; }
        public string? FrgHex { get; set; }
        public int BkgRed { get; set; }
        public int BkgGreen { get; set; }
        public int BkgBlue { get; set; }
        public string? BkgHex { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
