using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class CustomerAdresses
    {
        public CustomerAdresses()
        {
            CustomerAdressesEdit = new HashSet<CustomerAdressesEdit>();
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int CityId { get; set; }
        public int? DistrictId { get; set; }
        public string Village { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Enterance { get; set; }
        public string Floor { get; set; }
        public string Apartment { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string AddressNote { get; set; }
        public bool IsActive { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public int? AreaDivisionId { get; set; }

        public virtual AreaDivisions AreaDivision { get; set; }
        public virtual Cities City { get; set; }
        public virtual Users CreatedByNavigation { get; set; }
        public virtual Customers Customer { get; set; }
        public virtual Districts District { get; set; }
        public virtual Users ModifiedByNavigation { get; set; }
        public virtual ICollection<CustomerAdressesEdit> CustomerAdressesEdit { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
