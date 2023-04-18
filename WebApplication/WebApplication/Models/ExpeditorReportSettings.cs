using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class ExpeditorReportSettings
    {
        public int Id { get; set; }
        public int DriverId { get; set; }
        public string ReportText { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Drivers Driver { get; set; }
    }
}
