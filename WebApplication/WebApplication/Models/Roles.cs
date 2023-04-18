using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class Roles
    {
        public Roles()
        {
            AspNetRoleClaims = new HashSet<AspNetRoleClaims>();
            UserRoles = new HashSet<UserRoles>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public string ConcurrencyStamp { get; set; }

        public virtual ICollection<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }
}
