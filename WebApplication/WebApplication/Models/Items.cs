using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class Items
    {
        public Items()
        {
            OrderLimits = new HashSet<OrderLimits>();
            OrderProcessLine = new HashSet<OrderProcessLine>();
            Orders = new HashSet<Orders>();
            SubItems = new HashSet<SubItems>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool SizeCheck { get; set; }
        public bool DefaultSelected { get; set; }
        public double Price { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool ProductSales { get; set; }
        public bool NotIncluded { get; set; }
        public int? OrderOperationStatusId { get; set; }
        public string SmsText { get; set; }

        public virtual Users CreatedByNavigation { get; set; }
        public virtual Users ModifiedByNavigation { get; set; }
        public virtual ICollection<OrderLimits> OrderLimits { get; set; }
        public virtual ICollection<OrderProcessLine> OrderProcessLine { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<SubItems> SubItems { get; set; }
    }
}
