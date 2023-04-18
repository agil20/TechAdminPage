using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class Customers
    {
        public Customers()
        {
            CustomerAdresses = new HashSet<CustomerAdresses>();
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string FullName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Pin { get; set; }
        public string PhoneNumber1 { get; set; }
        public bool CheckWpPhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public bool CheckWpPhoneNumber2 { get; set; }
        public string HomeNumber { get; set; }
        public byte GroupType { get; set; }
        public bool SendSms { get; set; }
        public string Note { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsActive { get; set; }
        public string Id1c { get; set; }
        public bool BlackList { get; set; }

        public virtual Users CreatedByNavigation { get; set; }
        public virtual Users ModifiedByNavigation { get; set; }
        public virtual ICollection<CustomerAdresses> CustomerAdresses { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
