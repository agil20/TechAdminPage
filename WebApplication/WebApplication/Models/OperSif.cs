using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class OperSif
    {
        public string OperatorName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string OrderStatus { get; set; }
        public int? OrderCount { get; set; }
    }
}
