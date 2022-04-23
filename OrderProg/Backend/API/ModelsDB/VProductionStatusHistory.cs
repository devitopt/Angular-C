using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VProductionStatusHistory
    {
        public int OrderId { get; set; }
        public string IdOrder { get; set; }
        public DateTime StatusDate { get; set; }
        public int? LinesRunning { get; set; }
        public int? DailyOutput { get; set; }
        public double? OrderQuantityPlaced { get; set; }
        public int? OutputTotal { get; set; }
    }
}
