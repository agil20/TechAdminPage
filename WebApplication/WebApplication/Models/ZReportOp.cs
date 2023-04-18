using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class ZReportOp
    {
        public string FactNo { get; set; }
        public string CustName { get; set; }
        public DateTime OrderTakeDate { get; set; }
        public DateTime CustomerWantDate { get; set; }
        public string ExpeditorName { get; set; }
        public double? FactAmount { get; set; }
        public double? FactLastAmount { get; set; }
        public double? FactDiscountAmount { get; set; }
        public double? FactDiscountPercent { get; set; }
        public double? FactAdditionalCost { get; set; }
        public string ItemName { get; set; }
        public string SubItemName { get; set; }
        public bool? GuaranteeCheck { get; set; }
        public bool? Herbaceous { get; set; }
        public bool? OverlockCheck { get; set; }
        public double? OverlockPrice { get; set; }
        public double? OverlockAmount { get; set; }
        public bool? RepairCheck { get; set; }
        public double? RepairAmount { get; set; }
        public double? ItemWidth { get; set; }
        public double? ItemLength { get; set; }
        public double? ItemPrice { get; set; }
        public double? ItemAmount { get; set; }
        public double? ItemLastAmount { get; set; }
        public double? ItemDiscount { get; set; }
    }
}
