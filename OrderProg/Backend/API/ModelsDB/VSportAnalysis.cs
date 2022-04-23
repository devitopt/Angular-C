using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VSportAnalysis
    {
        public int Id { get; set; }
        public string IdOrder { get; set; }
        public string OrderDescription { get; set; }
        public string Clients { get; set; }
        public string Season { get; set; }
        public string Fabrikgruppe { get; set; }
        public string Fabrik { get; set; }
        public int? LatestDailyOutput { get; set; }
        public int? Output2 { get; set; }
        public int? Output3 { get; set; }
        public int? OutputSum { get; set; }
        public double? EkInEuro { get; set; }
        public double? EkInDollar { get; set; }
        public double? QuantityOrderedByClient { get; set; }
        public double? OrderQuantityPlaced { get; set; }
        public string Merchandiser { get; set; }
        public double? SellingPrice { get; set; }
        public double? Deckungsbeitrag { get; set; }
        public DateTime? SaleDate { get; set; }
        public string Laboratory { get; set; }
        public DateTime? Etd { get; set; }
        public DateTime? Eta { get; set; }
        public DateTime? OriginalSamplePickDate { get; set; }
        public DateTime? NewSamplePickDate { get; set; }
        public string SamplePickResult { get; set; }
        public DateTime? Fridate { get; set; }
        public DateTime? Fri2date { get; set; }
        public string Friresult { get; set; }
        public DateTime? CargoReadyDate { get; set; }
        public string BuyingAgent { get; set; }
        public string FabricSupplier { get; set; }
        public DateTime? OrderSheetDate { get; set; }
        public DateTime? AribaConfirmationDate { get; set; }
        public DateTime? InfoblattDate { get; set; }
        public DateTime? SubmitVvp { get; set; }
        public DateTime? SubmittPdp { get; set; }
        public string Technician { get; set; }
        public string VpppassformResult { get; set; }
        public DateTime? VpppassformDate { get; set; }
        public string PdppassformResult { get; set; }
        public DateTime? PdppassformDate { get; set; }
        public string Sample { get; set; }
        public string OpticalPattern { get; set; }
        public string MerchandiserPacking { get; set; }
        public string Graphics { get; set; }
        public DateTime? GraphicOrder { get; set; }
        public string LabelResult { get; set; }
        public DateTime? LabelDate { get; set; }
        public string PackingResult { get; set; }
        public DateTime? PackingDate { get; set; }
        public string Ctsresult { get; set; }
        public DateTime? Ctsdate { get; set; }
        public string OekotexResult { get; set; }
        public DateTime? OekotexDate { get; set; }
        public DateTime? FabricExDate { get; set; }
        public DateTime? FabricInhouseDate { get; set; }
        public DateTime? ZcartonsNord { get; set; }
        public string Comment { get; set; }
        public DateTime? StatusDate { get; set; }
        public int? UnitsPerCarton { get; set; }
        public string Ibnumber { get; set; }
        public decimal? CartonLength { get; set; }
        public decimal? CartonWidth { get; set; }
        public decimal? CartonHeight { get; set; }
        public DateTime? CustomerDeliveryDateFrom { get; set; }
        public DateTime? CustomerDeliveryDateTill { get; set; }
    }
}
