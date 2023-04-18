using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class ReportUser
    {
        public ReportUser()
        {
            ReporUserRoleMapping = new HashSet<ReporUserRoleMapping>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Password { get; set; }
        public DateTime? Createdate { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<ReporUserRoleMapping> ReporUserRoleMapping { get; set; }
    }
}
