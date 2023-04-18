using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class Users
    {
        public Users()
        {
            AreaDivisionsCreatedByNavigation = new HashSet<AreaDivisions>();
            AreaDivisionsModifiedByNavigation = new HashSet<AreaDivisions>();
            AspNetUserClaims = new HashSet<AspNetUserClaims>();
            AspNetUserLogins = new HashSet<AspNetUserLogins>();
            AspNetUserTokens = new HashSet<AspNetUserTokens>();
            CashCreatedByNavigation = new HashSet<Cash>();
            CashModifiedByNavigation = new HashSet<Cash>();
            CustomerAdressesCreatedByNavigation = new HashSet<CustomerAdresses>();
            CustomerAdressesEditCreatedByNavigation = new HashSet<CustomerAdressesEdit>();
            CustomerAdressesEditModifiedByNavigation = new HashSet<CustomerAdressesEdit>();
            CustomerAdressesModifiedByNavigation = new HashSet<CustomerAdresses>();
            CustomersCreatedByNavigation = new HashSet<Customers>();
            CustomersModifiedByNavigation = new HashSet<Customers>();
            DriverAndAssistantsCreatedByNavigation = new HashSet<DriverAndAssistants>();
            DriverAndAssistantsModifiedByNavigation = new HashSet<DriverAndAssistants>();
            DriversCreatedByNavigation = new HashSet<Drivers>();
            DriversModifiedByNavigation = new HashSet<Drivers>();
            DriversUser = new HashSet<Drivers>();
            InformationResourceCreatedByNavigation = new HashSet<InformationResource>();
            InformationResourceModifiedByNavigation = new HashSet<InformationResource>();
            InverseModifiedByNavigation = new HashSet<Users>();
            ItemsCreatedByNavigation = new HashSet<Items>();
            ItemsModifiedByNavigation = new HashSet<Items>();
            MmsCreatedByNavigation = new HashSet<Mms>();
            MmsModifiedByNavigation = new HashSet<Mms>();
            MobileNotificationsCreatedByNavigation = new HashSet<MobileNotifications>();
            MobileNotificationsModifiedByNavigation = new HashSet<MobileNotifications>();
            OrderLimitsCreatedByNavigation = new HashSet<OrderLimits>();
            OrderLimitsModifiedByNavigation = new HashSet<OrderLimits>();
            OrderProcessCreatedByNavigation = new HashSet<OrderProcess>();
            OrderProcessLineCreatedByNavigation = new HashSet<OrderProcessLine>();
            OrderProcessLineModifiedByNavigation = new HashSet<OrderProcessLine>();
            OrderProcessModifiedByNavigation = new HashSet<OrderProcess>();
            OrdersCreatedByNavigation = new HashSet<Orders>();
            OrdersModifiedByNavigation = new HashSet<Orders>();
            RefreshTokens = new HashSet<RefreshTokens>();
            StartWorkLogCreatedByNavigation = new HashSet<StartWorkLog>();
            StartWorkLogModifiedByNavigation = new HashSet<StartWorkLog>();
            SubItemsCreatedByNavigation = new HashSet<SubItems>();
            SubItemsModifiedByNavigation = new HashSet<SubItems>();
            UserRoles = new HashSet<UserRoles>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public int? JobTitle { get; set; }
        public bool? IsActive { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public bool IsAdmin { get; set; }
        public string Password { get; set; }
        public string FcmToken { get; set; }

        public virtual Users ModifiedByNavigation { get; set; }
        public virtual ICollection<AreaDivisions> AreaDivisionsCreatedByNavigation { get; set; }
        public virtual ICollection<AreaDivisions> AreaDivisionsModifiedByNavigation { get; set; }
        public virtual ICollection<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual ICollection<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual ICollection<Cash> CashCreatedByNavigation { get; set; }
        public virtual ICollection<Cash> CashModifiedByNavigation { get; set; }
        public virtual ICollection<CustomerAdresses> CustomerAdressesCreatedByNavigation { get; set; }
        public virtual ICollection<CustomerAdressesEdit> CustomerAdressesEditCreatedByNavigation { get; set; }
        public virtual ICollection<CustomerAdressesEdit> CustomerAdressesEditModifiedByNavigation { get; set; }
        public virtual ICollection<CustomerAdresses> CustomerAdressesModifiedByNavigation { get; set; }
        public virtual ICollection<Customers> CustomersCreatedByNavigation { get; set; }
        public virtual ICollection<Customers> CustomersModifiedByNavigation { get; set; }
        public virtual ICollection<DriverAndAssistants> DriverAndAssistantsCreatedByNavigation { get; set; }
        public virtual ICollection<DriverAndAssistants> DriverAndAssistantsModifiedByNavigation { get; set; }
        public virtual ICollection<Drivers> DriversCreatedByNavigation { get; set; }
        public virtual ICollection<Drivers> DriversModifiedByNavigation { get; set; }
        public virtual ICollection<Drivers> DriversUser { get; set; }
        public virtual ICollection<InformationResource> InformationResourceCreatedByNavigation { get; set; }
        public virtual ICollection<InformationResource> InformationResourceModifiedByNavigation { get; set; }
        public virtual ICollection<Users> InverseModifiedByNavigation { get; set; }
        public virtual ICollection<Items> ItemsCreatedByNavigation { get; set; }
        public virtual ICollection<Items> ItemsModifiedByNavigation { get; set; }
        public virtual ICollection<Mms> MmsCreatedByNavigation { get; set; }
        public virtual ICollection<Mms> MmsModifiedByNavigation { get; set; }
        public virtual ICollection<MobileNotifications> MobileNotificationsCreatedByNavigation { get; set; }
        public virtual ICollection<MobileNotifications> MobileNotificationsModifiedByNavigation { get; set; }
        public virtual ICollection<OrderLimits> OrderLimitsCreatedByNavigation { get; set; }
        public virtual ICollection<OrderLimits> OrderLimitsModifiedByNavigation { get; set; }
        public virtual ICollection<OrderProcess> OrderProcessCreatedByNavigation { get; set; }
        public virtual ICollection<OrderProcessLine> OrderProcessLineCreatedByNavigation { get; set; }
        public virtual ICollection<OrderProcessLine> OrderProcessLineModifiedByNavigation { get; set; }
        public virtual ICollection<OrderProcess> OrderProcessModifiedByNavigation { get; set; }
        public virtual ICollection<Orders> OrdersCreatedByNavigation { get; set; }
        public virtual ICollection<Orders> OrdersModifiedByNavigation { get; set; }
        public virtual ICollection<RefreshTokens> RefreshTokens { get; set; }
        public virtual ICollection<StartWorkLog> StartWorkLogCreatedByNavigation { get; set; }
        public virtual ICollection<StartWorkLog> StartWorkLogModifiedByNavigation { get; set; }
        public virtual ICollection<SubItems> SubItemsCreatedByNavigation { get; set; }
        public virtual ICollection<SubItems> SubItemsModifiedByNavigation { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }
}
