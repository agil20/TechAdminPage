using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class ReportRole
    {
        public ReportRole()
        {
            ReporUserRoleMapping = new HashSet<ReporUserRoleMapping>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string MenuGroup { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ReporUserRoleMapping> ReporUserRoleMapping { get; set; }
    }
}
