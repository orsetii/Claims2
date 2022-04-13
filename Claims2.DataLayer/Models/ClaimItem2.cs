using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ClaimItem2
    {
        public ClaimItem2()
        {
            Claim1s = new HashSet<Claim1>();
            ReplacementItems = new HashSet<ReplacementItem>();
            ValidationClaimItemValues = new HashSet<ValidationClaimItemValue>();
        }

        public int ItemId { get; set; }
        public int ClaimId { get; set; }
        public int ProductId { get; set; }
        public int? ReplacementId { get; set; }
        public int? CheapestBrandReplacementId { get; set; }
        public int? ProductItemId { get; set; }
        public DateTime DateAdded { get; set; }
        public int? AlternateOutcome { get; set; }
        public string? AlternateOutcomeExplanation { get; set; }
        public int? DetailId { get; set; }
        public int? AgeofProduct { get; set; }
        public double? ValueofProduct { get; set; }
        public int? NumberofProducts { get; set; }
        public string? RecommendedOutcome { get; set; }
        public string? RecommendedOutcomeIds { get; set; }
        public int? ChosenOutcome { get; set; }
        public string? ChosenOutcomeName { get; set; }
        public string? SerialNo { get; set; }
        public string? Description { get; set; }
        public string? Htmldetails { get; set; }
        public int? LiveSystemId { get; set; }
        public int? ChosenSupplierId { get; set; }
        public int? ChosenOldSupplierId { get; set; }
        public string? ChosenSupplier { get; set; }
        public decimal? ChosenSupplierPrice { get; set; }
        public string? CheapestSupplier { get; set; }
        public decimal? CheapestSupplierPrice { get; set; }
        public string? CheapestBrandSupplier { get; set; }
        public decimal? CheapestBrandPrice { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public decimal? BuyRate { get; set; }
        public decimal? SellRate { get; set; }
        public int? ItemTypeId { get; set; }
        public int? CheapestBrandProduct { get; set; }
        public int? UpgradeProductId { get; set; }
        public bool? ChoseUpgraded { get; set; }
        public string? UpgradeCheapestSupplier { get; set; }
        public decimal? UpgradeCheapestPrice { get; set; }
        public Guid? Guid { get; set; }
        public int? SbsitemId { get; set; }
        public string? ServiceRequestPublicId { get; set; }
        public bool IsSpecified { get; set; }
        public decimal? VoucherAmount { get; set; }
        public bool ExcessDeducted { get; set; }
        public string? DuckCreekItemRef { get; set; }

        public virtual AlternativeOutcome? AlternateOutcomeNavigation { get; set; }
        public virtual ValidationOutcome? ChosenOutcomeNavigation { get; set; }
        public virtual Claim1 Claim { get; set; } = null!;
        public virtual ICollection<Claim1> Claim1s { get; set; }
        public virtual ICollection<ReplacementItem> ReplacementItems { get; set; }
        public virtual ICollection<ValidationClaimItemValue> ValidationClaimItemValues { get; set; }
    }
}
