using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ImportSetting
    {
        public int Id { get; set; }
        public string? Insurer { get; set; }
        public string? EmailAddress { get; set; }
        public string? PolicyHolderNameRegion { get; set; }
        public string? HomePhoneRegion { get; set; }
        public string? PolicyExcessRegion { get; set; }
        public string? PolicyHolderEmailRegion { get; set; }
        public string? AddressRegion { get; set; }
        public string? PostCodeRegion { get; set; }
        public string? WorkPhoneRegion { get; set; }
        public string? MobileRegion { get; set; }
        public string? InstructionTextRegion { get; set; }
        public string? DescriptionRegion { get; set; }
        public string? LarefRegion { get; set; }
        public string? PolicyNumberRegion { get; set; }
    }
}
