using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Value1
    {
        public Value1()
        {
            ActionProfileDetails = new HashSet<ActionProfileDetail>();
            ClaimItemItemTypes = new HashSet<ClaimItem>();
            ClaimItemPerilDetails = new HashSet<ClaimItem>();
            ClaimItemPerils = new HashSet<ClaimItem>();
            ClaimItemValues = new HashSet<ClaimItemValue>();
            ClaimValues = new HashSet<ClaimValue>();
            FeeProductTypes = new HashSet<FeeProductType>();
            GemCaratMappingGemCarats = new HashSet<GemCaratMapping>();
            GemCaratMappingGemCuts = new HashSet<GemCaratMapping>();
            GemCaratMappingGemDimensions = new HashSet<GemCaratMapping>();
            GemCaratMappingGemTypes = new HashSet<GemCaratMapping>();
            GemClarityClarities = new HashSet<GemClarity>();
            GemClarityGems = new HashSet<GemClarity>();
            GemValMappings = new HashSet<GemValMapping>();
            OutcomeCommodities = new HashSet<OutcomeCommodity>();
            ServiceProductTypes = new HashSet<ServiceProductType>();
            UserCommodities = new HashSet<UserCommodity>();
            ValidationClaimItemValues = new HashSet<ValidationClaimItemValue>();
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
        public string? Lvalias { get; set; }
        public string? AdmiralAlias { get; set; }
        public string? AllianzAlias { get; set; }
        public int? NextParameterId { get; set; }
        public string? AgeasName { get; set; }

        public virtual Family? Gfkfamily { get; set; }
        public virtual ICollection<ActionProfileDetail> ActionProfileDetails { get; set; }
        public virtual ICollection<ClaimItem> ClaimItemItemTypes { get; set; }
        public virtual ICollection<ClaimItem> ClaimItemPerilDetails { get; set; }
        public virtual ICollection<ClaimItem> ClaimItemPerils { get; set; }
        public virtual ICollection<ClaimItemValue> ClaimItemValues { get; set; }
        public virtual ICollection<ClaimValue> ClaimValues { get; set; }
        public virtual ICollection<FeeProductType> FeeProductTypes { get; set; }
        public virtual ICollection<GemCaratMapping> GemCaratMappingGemCarats { get; set; }
        public virtual ICollection<GemCaratMapping> GemCaratMappingGemCuts { get; set; }
        public virtual ICollection<GemCaratMapping> GemCaratMappingGemDimensions { get; set; }
        public virtual ICollection<GemCaratMapping> GemCaratMappingGemTypes { get; set; }
        public virtual ICollection<GemClarity> GemClarityClarities { get; set; }
        public virtual ICollection<GemClarity> GemClarityGems { get; set; }
        public virtual ICollection<GemValMapping> GemValMappings { get; set; }
        public virtual ICollection<OutcomeCommodity> OutcomeCommodities { get; set; }
        public virtual ICollection<ServiceProductType> ServiceProductTypes { get; set; }
        public virtual ICollection<UserCommodity> UserCommodities { get; set; }
        public virtual ICollection<ValidationClaimItemValue> ValidationClaimItemValues { get; set; }
    }
}
