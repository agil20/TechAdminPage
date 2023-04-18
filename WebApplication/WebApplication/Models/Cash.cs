using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class Cash
    {
        public Cash()
        {
            CashLine = new HashSet<CashLine>();
        }

        public int Id { get; set; }
        public double Amount { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int DriverId { get; set; }

        public virtual Users CreatedByNavigation { get; set; }
        public virtual Users ModifiedByNavigation { get; set; }
        public virtual ICollection<CashLine> CashLine { get; set; }
    }
}
