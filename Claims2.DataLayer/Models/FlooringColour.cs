using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    /// <summary>
    /// Colours specific to a supplier
    /// </summary>
    public partial class FlooringColour
    {
        public int FlColourId { get; set; }
        public string Name { get; set; } = null!;
        public int? FlooringId { get; set; }
        public string? GenericColourName { get; set; }

        public virtual Flooring? Flooring { get; set; }
    }
}
