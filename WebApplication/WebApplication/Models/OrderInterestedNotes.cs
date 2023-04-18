using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class OrderInterestedNotes
    {
        public OrderInterestedNotes()
        {
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
