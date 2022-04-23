using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class FabricStatusReport
    {
        public int FabricStatusReportId { get; set; }
        public int OrderId { get; set; }
        public string Item { get; set; }
        public string Sachbearbeiter { get; set; }
        public string Gpextern { get; set; }
        public string GarmentSupplier { get; set; }
        public string FabricSupplier { get; set; }
        public int FabricQty { get; set; }
        public string FabricUnit { get; set; }
        public string FunctionBreathability { get; set; }
        public string FunctionWaterColumn { get; set; }
        public string FunctionAirpermeability { get; set; }
        public string FunctionSprayTest { get; set; }
        public string FunctionMoistureManagement { get; set; }
        public string FunctionResultBreathability { get; set; }
        public string FunctionResultWaterColumn { get; set; }
        public string FunctionResultAirpermeability { get; set; }
        public string FunctionResultSprayTest { get; set; }
        public string FunctionResultMoistureManagement { get; set; }
        public string FunctionEmpty { get; set; }
        public string Spinning { get; set; }
        public string WeavingKnitting { get; set; }
        public string DyeingPrinting { get; set; }
        public string CoatingBonding { get; set; }
        public DateTime QualityDate { get; set; }
        public DateTime LabDipsHandloomDate { get; set; }
        public string OriginalFabricSupplier { get; set; }
        public DateTime OriginalFabricDate { get; set; }
        public string GreigeQtySupplier { get; set; }
        public int GreigeQtyDate { get; set; }
        public string DyeingPrintingQtySupplier { get; set; }
        public int DyeingPrintingQtyCompleted { get; set; }
        public DateTime BvselftestingDate { get; set; }
        public string Bvresult { get; set; }
        public DateTime LabtechRetestingDate { get; set; }
        public string LabtechResult { get; set; }
        public DateTime InspectionPlan1stLotDate { get; set; }
        public string InspectionPlan1stLotSupplier { get; set; }
        public string InspectionPlan1stLotUnit { get; set; }
        public int InspectionPlan1stLotQty { get; set; }
        public DateTime InspectionPlan2stLotDate { get; set; }
        public string InspectionPlan2stLotSupplier { get; set; }
        public string InspectionPlan2stLotUnit { get; set; }
        public int InspectionPlan2stLotQty { get; set; }
        public DateTime InspectionPlan3stLotDate { get; set; }
        public string InspectionPlan3stLotSupplier { get; set; }
        public string InspectionPlan3stLotUnit { get; set; }
        public int InspectionPlan3stLotQty { get; set; }
        public DateTime InspectionPlan4stLotDate { get; set; }
        public string InspectionPlan4stLotSupplier { get; set; }
        public string InspectionPlan4stLotUnit { get; set; }
        public int InspectionPlan4stLotQty { get; set; }
        public DateTime InspectionPlan5stLotDate { get; set; }
        public string InspectionPlan5stLotSupplier { get; set; }
        public string InspectionPlan5stLotUnit { get; set; }
        public int InspectionPlan5stLotQty { get; set; }
        public DateTime Shipment1stLotDate { get; set; }
        public string Shipment1stLotSupplier { get; set; }
        public string Shipment1stLotUnit { get; set; }
        public int Shipment1stLotQty { get; set; }
        public DateTime Shipment2stLotDate { get; set; }
        public string Shipment2stLotSupplier { get; set; }
        public string Shipment2stLotUnit { get; set; }
        public int Shipment2stLotQty { get; set; }
        public DateTime Shipment3stLotDate { get; set; }
        public string Shipment3stLotSupplier { get; set; }
        public string Shipment3stLotUnit { get; set; }
        public int Shipment3stLotQty { get; set; }
        public DateTime Shipment4stLotDate { get; set; }
        public string Shipment4stLotSupplier { get; set; }
        public string Shipment4stLotUnit { get; set; }
        public int Shipment4stLotQty { get; set; }
        public DateTime Shipment5stLotDate { get; set; }
        public string Shipment5stLotSupplier { get; set; }
        public string Shipment5stLotUnit { get; set; }
        public int Shipment5stLotQty { get; set; }
        public int TotalCompletedQty { get; set; }
        public int TotalShipped { get; set; }
        public string Remarks { get; set; }
        public DateTime StatusDate { get; set; }

        public virtual Order Order { get; set; }
    }
}
