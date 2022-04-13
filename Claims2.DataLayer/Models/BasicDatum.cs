using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class BasicDatum
    {
        public long Id { get; set; }
        public long ItemId { get; set; }
        public string? ItemUniqueId { get; set; }
        public string? ParentAsin { get; set; }
        public string? ItemTitle { get; set; }
        public string? ItemLongDesc { get; set; }
        public string? ItemPageUrl { get; set; }
        public string? AmznPageUrl { get; set; }
        public string? FmPageUrl { get; set; }
        public string? OfferPageUrl { get; set; }
        public string? OfferUsedUrl { get; set; }
        public string? TpFbaUrl { get; set; }
        public string? ItemImageUrl { get; set; }
        public string? ItemImageUrlSmall { get; set; }
        public string? ItemImageUrlLarge { get; set; }
        public string? ItemSalesrank { get; set; }
        public decimal? ListPrice { get; set; }
        public bool? ListPriceSpecified { get; set; }
        public bool? ItemIsFba { get; set; }
        public decimal? ItemPrice { get; set; }
        public string? ItemInventory { get; set; }
        public string? ItemShippingCharge { get; set; }
        public string? ItemCondition { get; set; }
        public string? ItemSeller { get; set; }
        public string? ItemMerchantId { get; set; }
        public long? ItemIsEligibleForPrime { get; set; }
        public long? ItemPoints { get; set; }
        public long? ItemMinHours { get; set; }
        public long? ItemMaxHours { get; set; }
        public bool? AmznIsFba { get; set; }
        public decimal? AmznPrice { get; set; }
        public string? AmznInventory { get; set; }
        public string? AmznShippingCharge { get; set; }
        public string? AmznCondition { get; set; }
        public string? AmznSeller { get; set; }
        public string? AmznMerchantId { get; set; }
        public long? AmznIsEligibleForPrime { get; set; }
        public string? AmznPoints { get; set; }
        public long? AmznMinHours { get; set; }
        public long? AmznMaxHours { get; set; }
        public bool? FmIsFba { get; set; }
        public decimal? FmPrice { get; set; }
        public string? FmInventory { get; set; }
        public string? FmShippingCharge { get; set; }
        public string? FmCondition { get; set; }
        public string? FmSeller { get; set; }
        public string? FmMerchantId { get; set; }
        public long? FmIsEligibleForPrime { get; set; }
        public string? FmPoints { get; set; }
        public long? FmMinHours { get; set; }
        public long? FmMaxHours { get; set; }
        public bool? TpNewIsFba { get; set; }
        public bool? TpNewIsFbaSpecified { get; set; }
        public decimal? TpNewPrice { get; set; }
        public bool? TpNewPriceSpecified { get; set; }
        public string? TpNewInventory { get; set; }
        public string? TpNewShippingCharge { get; set; }
        public string? TpNewCondition { get; set; }
        public string? TpNewSeller { get; set; }
        public string? TpNewMerchantId { get; set; }
        public bool? TpNewIsEligibleForPrime { get; set; }
        public bool? TpNewIsEligibleForPrimeSpecified { get; set; }
        public string? TpNewPoints { get; set; }
        public long? TpNewMinHours { get; set; }
        public bool? TpNewMinHoursSpecified { get; set; }
        public long? TpNewMaxHours { get; set; }
        public bool? TpNewMaxHoursSpecified { get; set; }
        public string? ItemIsAdultProduct { get; set; }
        public string? AmznPpu { get; set; }
        public string? TpNewPpu { get; set; }
        public string? TpUsedPpu { get; set; }
        public string? TpRefurbishedPpu { get; set; }
        public string? TpCollectPpu { get; set; }
        public string? ItemEnergyEfficiencyClass { get; set; }

        public virtual Item Item { get; set; } = null!;
    }
}
