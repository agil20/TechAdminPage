using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class Districts
    {
        public Districts()
        {
            CustomerAdresses = new HashSet<CustomerAdresses>();
            CustomerAdressesEdit = new HashSet<CustomerAdressesEdit>();
            Streets = new HashSet<Streets>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Cities City { get; set; }
        public virtual ICollection<CustomerAdresses> CustomerAdresses { get; set; }
        public virtual ICollection<CustomerAdressesEdit> CustomerAdressesEdit { get; set; }
        public virtual ICollection<Streets> Streets { get; set; }
    }
}
