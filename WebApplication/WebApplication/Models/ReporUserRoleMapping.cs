using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class ReporUserRoleMapping
    {
        public int Id { get; set; }
        public int ReportUserId { get; set; }
        public int ReportRoleId { get; set; }

        public virtual ReportRole ReportRole { get; set; }
        public virtual ReportUser ReportUser { get; set; }
    }
}
