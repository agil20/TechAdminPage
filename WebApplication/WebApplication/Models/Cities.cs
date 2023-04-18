using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class Cities
    {
        public Cities()
        {
            CustomerAdresses = new HashSet<CustomerAdresses>();
            CustomerAdressesEdit = new HashSet<CustomerAdressesEdit>();
            Districts = new HashSet<Districts>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<CustomerAdresses> CustomerAdresses { get; set; }
        public virtual ICollection<CustomerAdressesEdit> CustomerAdressesEdit { get; set; }
        public virtual ICollection<Districts> Districts { get; set; }
    }
}
