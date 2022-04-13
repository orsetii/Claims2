using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class VatRate
    {
        public int VrId { get; set; }
        /// <summary>
        /// eg Standard, Zero, etc
        /// </summary>
        public string VrName { get; set; } = null!;
        /// <summary>
        /// as per Sage, eg. T1 = Standard, T0 = Zero
        /// </summary>
        public string VrCode { get; set; } = null!;
        /// <summary>
        /// For old rates - don&apos;t allow further use
        /// </summary>
        public bool VrActive { get; set; }
        /// <summary>
        /// Store as % (eg 17.5 not 0.175)
        /// </summary>
        public decimal VrRate { get; set; }
        /// <summary>
        /// To flag the default standard rate code
        /// </summary>
        public bool VrDefaultCode { get; set; }
        public int? VrCreatedBy { get; set; }
        public DateTime? VrCreatedOn { get; set; }
        public int? VrEditedBy { get; set; }
        public DateTime? VrEditedOn { get; set; }
    }
}
