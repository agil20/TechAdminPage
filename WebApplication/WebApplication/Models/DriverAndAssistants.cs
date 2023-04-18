using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class DriverAndAssistants
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Users CreatedByNavigation { get; set; }
        public virtual Users ModifiedByNavigation { get; set; }
    }
}
