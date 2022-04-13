using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class CsvUploadedDpdInvoice
    {
        public int CsvId { get; set; }
        public DateTime CsvUploadedOn { get; set; }
        public int CsvUploadedBy { get; set; }
        public DateTime? CsvEditedOn { get; set; }
        public int? CsvEditedBy { get; set; }
        public int CsvBatchId { get; set; }
        public int CsvRowNumber { get; set; }
        public int? CsvUpdated { get; set; }
        public string? CsvUpdateFailMessage { get; set; }
        public string? CsvUpdateWarning { get; set; }
        public int? CsvPoNo { get; set; }
        public DateTime CsvDate { get; set; }
        public string? CsvConsignment { get; set; }
        public string? CsvHeader { get; set; }
        public string? CsvParcelNo { get; set; }
        public string? CsvProductCode { get; set; }
        public string? CsvProductDescription { get; set; }
        public string? CsvServiceCode { get; set; }
        public string? CsvServiceDescription { get; set; }
        public string? CsvDepotNo { get; set; }
        public string? CsvCollection { get; set; }
        public string? CsvDelivery { get; set; }
        public string? CsvSendersRef { get; set; }
        public string? CsvWeight { get; set; }
        public string? CsvItems { get; set; }
        public string? CsvVatcode { get; set; }
        public decimal? CsvRevenue { get; set; }
        public string? CsvSurcharge { get; set; }
        public decimal? CsvFuelSurcharge { get; set; }
        public decimal? CsvThirdPartyCollection { get; set; }
        public decimal? CsvFourthPartyCollection { get; set; }
        public decimal? CsvCongestionCharge { get; set; }
        public decimal? CsvCustomsCharge { get; set; }
        public decimal? CsvReturntoConsignorCharge { get; set; }
        public decimal? CsvFailedCollectionCharge { get; set; }
        public decimal? CsvScottishDeliveryZone { get; set; }
        public decimal? CsvDutyCharge { get; set; }
        public decimal? CsvHandlingCharge { get; set; }
        public decimal? CsvContractualLiability { get; set; }
        public decimal? CsvCover { get; set; }
        public string? CsvCountryCode { get; set; }
        public string? CsvCountry { get; set; }
        public string? CsvSecondRef { get; set; }
        public string? CsvThirdRef { get; set; }
        public string? CsvDeliveryAddress { get; set; }
        public string? CsvCollectionPostCode { get; set; }
        public decimal? CsvTotalCharge { get; set; }
        public int? CsvPoNumber { get; set; }
        public decimal? CsvPoValue { get; set; }
        public decimal? CsvOversizedExCharge { get; set; }
        public decimal? CsvUnsuccEecharge { get; set; }
        public decimal? CsvReturnEecharge { get; set; }
        public decimal? CsvHgvcharge { get; set; }
        public decimal? CsvNchandlingCharge { get; set; }
    }
}
