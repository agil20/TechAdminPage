using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class ReportIgnoredNumbers
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
