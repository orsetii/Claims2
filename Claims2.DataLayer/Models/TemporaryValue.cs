﻿using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class TemporaryValue
    {
        public TemporaryValue()
        {
            InverseParentValue = new HashSet<TemporaryValue>();
        }

        public int Id { get; set; }
        public int ParameterId { get; set; }
        public string Name { get; set; } = null!;
        public int? ParentValueId { get; set; }
        public int? CauseTypeId { get; set; }
        public int? SubcauseTypeId { get; set; }
        public int? ItemTypeId { get; set; }
        public int? GfkfamilyId { get; set; }
        public string? ImageUrl { get; set; }

        public virtual TemporaryParameter Parameter { get; set; } = null!;
        public virtual TemporaryValue? ParentValue { get; set; }
        public virtual ICollection<TemporaryValue> InverseParentValue { get; set; }
    }
}
