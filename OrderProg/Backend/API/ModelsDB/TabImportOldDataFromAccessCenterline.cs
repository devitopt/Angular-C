using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class TabImportOldDataFromAccessCenterline
    {
        public string Order { get; set; }
        public string Kunde { get; set; }
        public string Artikel { get; set; }
        public int? Menge { get; set; }
        public int? Kw { get; set; }
        public string LtVon { get; set; }
        public string LtBis { get; set; }
        public string Land { get; set; }
        public double? Ek1 { get; set; }
        public double? Ek2 { get; set; }
        public double? Ek3 { get; set; }
        public double? Vk { get; set; }
        public string Techniker { get; set; }
        public string Saison { get; set; }
        public DateTime? VerschTermin { get; set; }
        public string Lieferant { get; set; }
        public string Vertreter { get; set; }
        public float? Us { get; set; }
        public float? Kurs { get; set; }
        public string Lc { get; set; }
        public bool? Erledigt { get; set; }
        public string Sachb { get; set; }
        public string Prod { get; set; }
        public string Plaziert { get; set; }
        public string Verschiff2 { get; set; }
        public int? Verschmenge { get; set; }
        public int? Menge2 { get; set; }
        public string Ursprungslmeter { get; set; }
        public bool? Oauftrag { get; set; }
        public bool? Lcer { get; set; }
        public string Pg { get; set; }
    }
}
