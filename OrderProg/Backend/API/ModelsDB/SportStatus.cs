using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class SportStatus
    {
        public int SportStatusId { get; set; }
        public int OrdersId { get; set; }
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
        public DateTime StatusDate { get; set; }
        public int? UnitsPerCarton { get; set; }
        public string Ibnumber { get; set; }
        public decimal? CartonLength { get; set; }
        public decimal? CartonWidth { get; set; }
        public decimal? CartonHeight { get; set; }
        public int? PalettFactor { get; set; }
    }
}
