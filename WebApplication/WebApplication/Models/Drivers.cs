using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class Drivers
    {
        public Drivers()
        {
            AreaDivisions = new HashSet<AreaDivisions>();
            OrderLimits = new HashSet<OrderLimits>();
            OrderProcess = new HashSet<OrderProcess>();
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public string Code { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string WareHouseNo { get; set; }

        public virtual Users CreatedByNavigation { get; set; }
        public virtual Users ModifiedByNavigation { get; set; }
        public virtual Users User { get; set; }
        public virtual ExpeditorReportSettings ExpeditorReportSettings { get; set; }
        public virtual ICollection<AreaDivisions> AreaDivisions { get; set; }
        public virtual ICollection<OrderLimits> OrderLimits { get; set; }
        public virtual ICollection<OrderProcess> OrderProcess { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
