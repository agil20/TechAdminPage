using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class CashLine
    {
        public int Id { get; set; }
        public int CashId { get; set; }
        public int OrderId { get; set; }
        public double Amount { get; set; }

        public virtual Cash Cash { get; set; }
        public virtual Orders Order { get; set; }
    }
}
