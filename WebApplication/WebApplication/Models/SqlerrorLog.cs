using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class SqlerrorLog
    {
        public DateTime? LogDate { get; set; }
        public string ProcessInfo { get; set; }
        public string Text { get; set; }
    }
}
