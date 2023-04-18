using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class Pivot2022
    {
        public DateTime? Date { get; set; }
        public string Year { get; set; }
        public int? Month { get; set; }
        public string Day { get; set; }
        public string Item { get; set; }
        public double? Amount { get; set; }
    }
}
