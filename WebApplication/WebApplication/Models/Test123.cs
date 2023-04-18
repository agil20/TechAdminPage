using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class Test123
    {
        public int LogicalRef { get; set; }
        public int? Modul { get; set; }
        public int Type { get; set; }
        public double? Planlanan { get; set; }
        public double? Miqdar { get; set; }
        public DateTime? Tarix { get; set; }
        public string CreatedBy { get; set; }
    }
}
