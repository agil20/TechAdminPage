using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class SubItems
    {
        public SubItems()
        {
            OrderProcessLine = new HashSet<OrderProcessLine>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ItemId { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Users CreatedByNavigation { get; set; }
        public virtual Items Item { get; set; }
        public virtual Users ModifiedByNavigation { get; set; }
        public virtual ICollection<OrderProcessLine> OrderProcessLine { get; set; }
    }
}
