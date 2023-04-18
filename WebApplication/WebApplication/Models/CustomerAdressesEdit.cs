using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class CustomerAdressesEdit
    {
        public int Id { get; set; }
        public int CustomerAddressId { get; set; }
        public int CityId { get; set; }
        public int? DistrictId { get; set; }
        public string Village { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Enterance { get; set; }
        public string Floor { get; set; }
        public string Apartment { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string AddressNote { get; set; }

        public virtual Cities City { get; set; }
        public virtual Users CreatedByNavigation { get; set; }
        public virtual CustomerAdresses CustomerAddress { get; set; }
        public virtual Districts District { get; set; }
        public virtual Users ModifiedByNavigation { get; set; }
    }
}
