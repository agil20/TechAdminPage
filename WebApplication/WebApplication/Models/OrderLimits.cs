using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class OrderLimits
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int DriverId { get; set; }
        public int LimitNumber { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime BeginDate { get; set; }
        public int DefaultLimitNumber { get; set; }
        public DateTime EndDate { get; set; }

        public virtual Users CreatedByNavigation { get; set; }
        public virtual Drivers Driver { get; set; }
        public virtual Items Item { get; set; }
        public virtual Users ModifiedByNavigation { get; set; }
    }
}
