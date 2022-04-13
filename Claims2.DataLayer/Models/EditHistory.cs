using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class EditHistory
    {
        public int Id { get; set; }
        public string TableName { get; set; } = null!;
        public string PrimaryKey { get; set; } = null!;
        public int PrimaryKeyId { get; set; }
        public string FieldName { get; set; } = null!;
        public string? OldValue { get; set; }
        public string? NewValue { get; set; }
        public string UserName { get; set; } = null!;
        public DateTime DateModified { get; set; }
        public int InsuranceClaimId { get; set; }
    }
}
