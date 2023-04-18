using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class Order1c
    {
        public int Id { get; set; }
        public string OrderId { get; set; }
        public string ExpeditorName { get; set; }
        public string Service { get; set; }
        public DateTime? OrderDate { get; set; }
        public string Item { get; set; }
        public string SubItem { get; set; }
        public double? ItemLength { get; set; }
        public double? ItemWidth { get; set; }
        public double? ItemQty { get; set; }
        public double? ItemPrice { get; set; }
        public double? ItemAmount { get; set; }
        public double? ItemDiscount { get; set; }
        public string ClientUnicId { get; set; }
        public string OrderStatus { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }
    }
}
