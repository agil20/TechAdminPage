using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class Orders
    {
        public Orders()
        {
            CashLine = new HashSet<CashLine>();
            OrderProcess = new HashSet<OrderProcess>();
        }

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public byte OrderStatus { get; set; }
        public string OrderStatusNote { get; set; }
        public string ExpeditorReasonNotTake { get; set; }
        public DateTime CustomerWantDate { get; set; }
        public int? ItemId { get; set; }
        public int? DriverId { get; set; }
        public int? InfSourceId { get; set; }
        public string Note { get; set; }
        public int? CustomerAdressId { get; set; }
        public byte OperationStatus { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte ExistOrNewType { get; set; }
        public bool CheckExpeditorReasonNotTake { get; set; }
        public int? OrderInterestedNoteId { get; set; }
        public bool ChangedDateControl { get; set; }

        public virtual Users CreatedByNavigation { get; set; }
        public virtual Customers Customer { get; set; }
        public virtual CustomerAdresses CustomerAdress { get; set; }
        public virtual Drivers Driver { get; set; }
        public virtual InformationResource InfSource { get; set; }
        public virtual Items Item { get; set; }
        public virtual Users ModifiedByNavigation { get; set; }
        public virtual OrderInterestedNotes OrderInterestedNote { get; set; }
        public virtual Mms Mms { get; set; }
        public virtual ICollection<CashLine> CashLine { get; set; }
        public virtual ICollection<OrderProcess> OrderProcess { get; set; }
    }
}
