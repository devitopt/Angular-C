using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VDprSport
    {
        public int DatabaseId { get; set; }
        public string Sort { get; set; }
        public string Merchandiser { get; set; }
        public string OrderNumber { get; set; }
        public string Customer { get; set; }
        public string Title { get; set; }
        public string CustomerOrderNumber { get; set; }
        public string QuantityOrderedByClient { get; set; }
        public double? PurchasePrice { get; set; }
        public double? SellingPrice { get; set; }
        public double? Deckungsbeitrag { get; set; }
        public double? Lot { get; set; }
        public string Crd { get; set; }
        public DateTime? SaleDate { get; set; }
        public string Factory { get; set; }
        public string Laboratory { get; set; }
        public DateTime? ProductionStart { get; set; }
        public double? DaysToFinish { get; set; }
        public int? DailyOutput { get; set; }
        public string EstimatedEnd { get; set; }
        public DateTime? Etd { get; set; }
        public DateTime? Eta { get; set; }
        public DateTime? OriginalSamplePickDate { get; set; }
        public DateTime? NewSamplePickDate { get; set; }
        public string SamplePickResult { get; set; }
        public DateTime? Fridate { get; set; }
        public DateTime? Fri2date { get; set; }
        public string Friresult { get; set; }
    }
}
