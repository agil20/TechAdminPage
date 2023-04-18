using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class StartWorkLog
    {
        public int Id { get; set; }
        public string DriverName { get; set; }
        public string CarNumber { get; set; }
        public string Assistant { get; set; }
        public string Reserve { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte ModuleType { get; set; }
        public DateTime CreateShortDate { get; set; }

        public virtual Users CreatedByNavigation { get; set; }
        public virtual Users ModifiedByNavigation { get; set; }
    }
}
