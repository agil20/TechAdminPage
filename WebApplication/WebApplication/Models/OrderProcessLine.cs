using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class OrderProcessLine
    {
        public int Id { get; set; }
        public int OrderProcessId { get; set; }
        public int ItemId { get; set; }
        public int SubItemId { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public double Price { get; set; }
        public double Amount { get; set; }
        public double LastAmount { get; set; }
        public double Discount { get; set; }
        public bool? Herbaceous { get; set; }
        public bool? OverlockCheck { get; set; }
        public double? OverlockMeter { get; set; }
        public double? OverlockPrice { get; set; }
        public double? OverlockAmount { get; set; }
        public bool? RepairCheck { get; set; }
        public bool? GuaranteeCheck { get; set; }
        public double? RepairAmount { get; set; }
        public string RepairNote { get; set; }
        public string Note { get; set; }
        public int? LineId { get; set; }
        public string ReturnItemCode { get; set; }
        public int OperationStatus { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? LineIndex { get; set; }
        public bool IsActive { get; set; }
        public double Quantity { get; set; }
        public string InspectionPerson { get; set; }
        public bool IsAddAdmin { get; set; }
        public double? RepairM2 { get; set; }

        public virtual Users CreatedByNavigation { get; set; }
        public virtual Items Item { get; set; }
        public virtual Users ModifiedByNavigation { get; set; }
        public virtual OrderProcess OrderProcess { get; set; }
        public virtual SubItems SubItem { get; set; }
    }
}
