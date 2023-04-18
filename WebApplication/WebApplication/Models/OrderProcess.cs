using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class OrderProcess
    {
        public OrderProcess()
        {
            OrderProcessLine = new HashSet<OrderProcessLine>();
        }

        public int Id { get; set; }
        public int OrderId { get; set; }
        public double? DiscountPercent { get; set; }
        public double? DiscountAmount { get; set; }
        public double? AdditionalCost { get; set; }
        public double? Amount { get; set; }
        public double? LastAmount { get; set; }
        public string Note { get; set; }
        public int OperationStatus { get; set; }
        public int? DriverId { get; set; }
        public string ReturnFactNo { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public double? MinVisit { get; set; }
        public double PaymentAmount { get; set; }
        public int PaymentType { get; set; }
        public bool IsActive { get; set; }
        public int? AfterItemId { get; set; }
        public int? AfterOperatorId { get; set; }
        public int? BeforeItemId { get; set; }
        public int? BeforeOperatorId { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }

        public virtual Users CreatedByNavigation { get; set; }
        public virtual Drivers Driver { get; set; }
        public virtual Users ModifiedByNavigation { get; set; }
        public virtual Orders Order { get; set; }
        public virtual ICollection<OrderProcessLine> OrderProcessLine { get; set; }
    }
}
