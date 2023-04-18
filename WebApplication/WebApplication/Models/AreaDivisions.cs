using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class AreaDivisions
    {
        public AreaDivisions()
        {
            CustomerAdresses = new HashSet<CustomerAdresses>();
        }

        public int Id { get; set; }
        public string AreaName { get; set; }
        public int ExpeditorId { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Users CreatedByNavigation { get; set; }
        public virtual Drivers Expeditor { get; set; }
        public virtual Users ModifiedByNavigation { get; set; }
        public virtual ICollection<CustomerAdresses> CustomerAdresses { get; set; }
    }
}
