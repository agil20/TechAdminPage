using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebApplication.ViewModels;

namespace WebApplication.Models
{
    public partial class PakXalcaWebContext : DbContext
    {
        public PakXalcaWebContext()
        {
        }

        public PakXalcaWebContext(DbContextOptions<PakXalcaWebContext> options): base(options)
        {
        }


        public virtual DbSet<AreaDivisions> AreaDivisions { get; set; }
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<Cash> Cash { get; set; }
        public virtual DbSet<CashLine> CashLine { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<CustomerAdresses> CustomerAdresses { get; set; }
        public virtual DbSet<CustomerAdressesEdit> CustomerAdressesEdit { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Districts> Districts { get; set; }
        public virtual DbSet<DriverAndAssistants> DriverAndAssistants { get; set; }
        public virtual DbSet<Drivers> Drivers { get; set; }
        public virtual DbSet<ExpeditorReportSettings> ExpeditorReportSettings { get; set; }
        public virtual DbSet<InformationResource> InformationResource { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<KvadratNov> KvadratNov { get; set; }
        public virtual DbSet<Mms> Mms { get; set; }
        public virtual DbSet<MobileNotifications> MobileNotifications { get; set; }
        public virtual DbSet<OperSif> OperSif { get; set; }
        public virtual DbSet<Order1c> Order1c { get; set; }
        public virtual DbSet<OrderInterestedNotes> OrderInterestedNotes { get; set; }
        public virtual DbSet<OrderLimits> OrderLimits { get; set; }
        public virtual DbSet<OrderProcess> OrderProcess { get; set; }
        public virtual DbSet<OrderProcessLine> OrderProcessLine { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<OrdersFor1c> OrdersFor1c { get; set; }
        public virtual DbSet<Pivot2022> Pivot2022 { get; set; }
        public virtual DbSet<RefreshTokens> RefreshTokens { get; set; }
        public virtual DbSet<ReporUserRoleMapping> ReporUserRoleMapping { get; set; }
        public virtual DbSet<ReportCdr> ReportCdr { get; set; }
        public virtual DbSet<ReportCdrTemp> ReportCdrTemp { get; set; }
        public virtual DbSet<ReportIgnoredNumbers> ReportIgnoredNumbers { get; set; }
        public virtual DbSet<ReportRole> ReportRole { get; set; }
        public virtual DbSet<ReportUser> ReportUser { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<SqlerrorLog> SqlerrorLog { get; set; }
        public virtual DbSet<StartWorkLog> StartWorkLog { get; set; }
        public virtual DbSet<Streets> Streets { get; set; }
        public virtual DbSet<SubItems> SubItems { get; set; }
        public virtual DbSet<Test123> Test123 { get; set; }
        public virtual DbSet<Test41> Test41 { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Villages> Villages { get; set; }
        public virtual DbSet<VwHesabatDovriyyeDetail2023> VwHesabatDovriyyeDetail2023 { get; set; }
        public virtual DbSet<VwPivotKvadratHesabati> VwPivotKvadratHesabati { get; set; }
        public virtual DbSet<ZOperatorOp> ZOperatorOp { get; set; }
        public virtual DbSet<ZReport2> ZReport2 { get; set; }
        public virtual DbSet<ZReportOp> ZReportOp { get; set; }
        public virtual DbSet<_1c> _1c { get; set; }
        public virtual DbSet<_1cCopy> _1cCopy { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=202.207.14.2;Database=PakXalcaWeb;uid=test_aqil;pwd=Read123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "test_aqil");

            modelBuilder.Entity<AreaDivisions>(entity =>
            {
                entity.ToTable("AreaDivisions", "dbo");

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ExpeditorId);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.AreaName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AreaDivisionsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Expeditor)
                    .WithMany(p => p.AreaDivisions)
                    .HasForeignKey(d => d.ExpeditorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AreaDivisionsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.ToTable("AspNetRoleClaims", "dbo");

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.ToTable("AspNetUserClaims", "dbo");

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.ToTable("AspNetUserLogins", "dbo");

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.ToTable("AspNetUserTokens", "dbo");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Cash>(entity =>
            {
                entity.ToTable("Cash", "dbo");

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CashCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CashModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<CashLine>(entity =>
            {
                entity.ToTable("CashLine", "dbo");

                entity.HasOne(d => d.Cash)
                    .WithMany(p => p.CashLine)
                    .HasForeignKey(d => d.CashId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.CashLine)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Cities>(entity =>
            {
                entity.ToTable("Cities", "dbo");

                entity.HasIndex(e => e.Name)
                    .IsUnique();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CustomerAdresses>(entity =>
            {
                entity.ToTable("CustomerAdresses", "dbo");

                entity.HasIndex(e => e.AreaDivisionId);

                entity.HasIndex(e => e.CityId);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.DistrictId);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Apartment).HasMaxLength(25);

                entity.Property(e => e.Enterance).HasMaxLength(25);

                entity.Property(e => e.Floor).HasMaxLength(25);

                entity.Property(e => e.House).HasMaxLength(25);

                entity.Property(e => e.Street).HasMaxLength(150);

                entity.Property(e => e.Village).HasMaxLength(150);

                entity.HasOne(d => d.AreaDivision)
                    .WithMany(p => p.CustomerAdresses)
                    .HasForeignKey(d => d.AreaDivisionId);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.CustomerAdresses)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CustomerAdressesCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerAdresses)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.District)
                    .WithMany(p => p.CustomerAdresses)
                    .HasForeignKey(d => d.DistrictId);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CustomerAdressesModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<CustomerAdressesEdit>(entity =>
            {
                entity.ToTable("CustomerAdressesEdit", "dbo");

                entity.HasIndex(e => e.CityId);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.CustomerAddressId);

                entity.HasIndex(e => e.DistrictId);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Apartment).HasMaxLength(25);

                entity.Property(e => e.Enterance).HasMaxLength(25);

                entity.Property(e => e.Floor).HasMaxLength(25);

                entity.Property(e => e.House).HasMaxLength(25);

                entity.Property(e => e.Street).HasMaxLength(150);

                entity.Property(e => e.Village).HasMaxLength(150);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.CustomerAdressesEdit)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CustomerAdressesEditCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CustomerAddress)
                    .WithMany(p => p.CustomerAdressesEdit)
                    .HasForeignKey(d => d.CustomerAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.District)
                    .WithMany(p => p.CustomerAdressesEdit)
                    .HasForeignKey(d => d.DistrictId);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CustomerAdressesEditModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.ToTable("Customers", "dbo");

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.HasIndex(e => e.PhoneNumber1)
                    .IsUnique();

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.FatherName).HasMaxLength(75);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(125);

                entity.Property(e => e.HomeNumber).HasMaxLength(21);

                entity.Property(e => e.Id1c).HasColumnName("ID_1C");

                entity.Property(e => e.LastName).HasMaxLength(75);

                entity.Property(e => e.Note).HasMaxLength(200);

                entity.Property(e => e.PhoneNumber1)
                    .IsRequired()
                    .HasMaxLength(21);

                entity.Property(e => e.PhoneNumber2).HasMaxLength(21);

                entity.Property(e => e.Pin).HasMaxLength(7);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CustomersCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CustomersModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<Districts>(entity =>
            {
                entity.ToTable("Districts", "dbo");

                entity.HasIndex(e => e.CityId);

                entity.HasIndex(e => new { e.Name, e.CityId })
                    .IsUnique();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Districts)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<DriverAndAssistants>(entity =>
            {
                entity.ToTable("DriverAndAssistants", "dbo");

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.HasIndex(e => new { e.Name, e.Type })
                    .IsUnique();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.DriverAndAssistantsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.DriverAndAssistantsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<Drivers>(entity =>
            {
                entity.ToTable("Drivers", "dbo");

                entity.HasIndex(e => e.Code)
                    .IsUnique();

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.DriversCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.DriversModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DriversUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ExpeditorReportSettings>(entity =>
            {
                entity.ToTable("ExpeditorReportSettings", "dbo");

                entity.HasIndex(e => e.DriverId)
                    .IsUnique();

                entity.Property(e => e.DriverId).HasColumnName("driverId");

                entity.Property(e => e.ReportText)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.Driver)
                    .WithOne(p => p.ExpeditorReportSettings)
                    .HasForeignKey<ExpeditorReportSettings>(d => d.DriverId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<InformationResource>(entity =>
            {
                entity.ToTable("InformationResource", "dbo");

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InformationResourceCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.InformationResourceModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<Items>(entity =>
            {
                entity.ToTable("Items", "dbo");

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.HasIndex(e => e.Name)
                    .IsUnique();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ItemsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ItemsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<KvadratNov>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Kvadrat_Nov", "dbo");

                entity.Property(e => e.Nov)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Mms>(entity =>
            {
                entity.ToTable("Mms", "dbo");

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.HasIndex(e => e.OrderId)
                    .IsUnique();

                entity.Property(e => e.AdditionalNote).HasMaxLength(200);

                entity.Property(e => e.CallResult).HasColumnName("callResult");

                entity.Property(e => e.IsOrderChecked).HasColumnName("isOrderChecked");

                entity.Property(e => e.NoAnswerNote)
                    .HasColumnName("noAnswerNote")
                    .HasMaxLength(200);

                entity.Property(e => e.OperatorNote).HasMaxLength(200);

                entity.Property(e => e.QualityControlAssessmentNote).HasMaxLength(200);

                entity.Property(e => e.ServiceNote).HasMaxLength(200);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.MmsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.MmsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);

                entity.HasOne(d => d.Order)
                    .WithOne(p => p.Mms)
                    .HasForeignKey<Mms>(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MobileNotifications>(entity =>
            {
                entity.ToTable("MobileNotifications", "dbo");

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Body).IsRequired();

                entity.Property(e => e.Title).IsRequired();

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.MobileNotificationsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.MobileNotificationsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<OperSif>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("oper_sif", "dbo");

                entity.Property(e => e.OperatorName)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.OrderStatus)
                    .IsRequired()
                    .HasMaxLength(17);
            });

            modelBuilder.Entity<Order1c>(entity =>
            {
                entity.ToTable("ORDER_1C", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(500);

                entity.Property(e => e.ClientUnicId)
                    .HasColumnName("CLIENT_UNIC_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.ExpeditorName)
                    .HasColumnName("EXPEDITOR_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Item)
                    .HasColumnName("ITEM")
                    .HasMaxLength(50);

                entity.Property(e => e.ItemAmount).HasColumnName("ITEM_AMOUNT");

                entity.Property(e => e.ItemDiscount).HasColumnName("ITEM_DISCOUNT");

                entity.Property(e => e.ItemLength).HasColumnName("ITEM_LENGTH");

                entity.Property(e => e.ItemPrice).HasColumnName("ITEM_PRICE");

                entity.Property(e => e.ItemQty).HasColumnName("ITEM_QTY");

                entity.Property(e => e.ItemWidth).HasColumnName("ITEM_WIDTH");

                entity.Property(e => e.Note)
                    .HasColumnName("NOTE")
                    .HasMaxLength(500);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("ORDER_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderId)
                    .HasColumnName("ORDER_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderStatus)
                    .HasColumnName("ORDER_STATUS")
                    .HasMaxLength(100);

                entity.Property(e => e.Service)
                    .HasColumnName("SERVICE")
                    .HasMaxLength(50);

                entity.Property(e => e.SubItem)
                    .HasColumnName("SUB_ITEM")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OrderInterestedNotes>(entity =>
            {
                entity.ToTable("OrderInterestedNotes", "dbo");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OrderLimits>(entity =>
            {
                entity.ToTable("OrderLimits", "dbo");

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.DriverId);

                entity.HasIndex(e => e.ModifiedBy);

                entity.HasIndex(e => new { e.ItemId, e.DriverId })
                    .IsUnique();

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.OrderLimitsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.OrderLimits)
                    .HasForeignKey(d => d.DriverId);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.OrderLimits)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.OrderLimitsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<OrderProcess>(entity =>
            {
                entity.ToTable("OrderProcess", "dbo");

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.DriverId);

                entity.HasIndex(e => e.ModifiedBy);

                entity.HasIndex(e => e.OrderId);

                entity.Property(e => e.Note).HasMaxLength(200);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.OrderProcessCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.OrderProcess)
                    .HasForeignKey(d => d.DriverId);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.OrderProcessModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderProcess)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<OrderProcessLine>(entity =>
            {
                entity.ToTable("OrderProcessLine", "dbo");

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ItemId);

                entity.HasIndex(e => e.ModifiedBy);

                entity.HasIndex(e => e.OrderProcessId);

                entity.HasIndex(e => e.SubItemId);

                entity.Property(e => e.IsAddAdmin).HasColumnName("isAddAdmin");

                entity.Property(e => e.Note).HasMaxLength(200);

                entity.Property(e => e.RepairNote).HasMaxLength(200);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.OrderProcessLineCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.OrderProcessLine)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.OrderProcessLineModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);

                entity.HasOne(d => d.OrderProcess)
                    .WithMany(p => p.OrderProcessLine)
                    .HasForeignKey(d => d.OrderProcessId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.SubItem)
                    .WithMany(p => p.OrderProcessLine)
                    .HasForeignKey(d => d.SubItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.ToTable("Orders", "dbo");

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.CustomerAdressId);

                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.DriverId);

                entity.HasIndex(e => e.InfSourceId);

                entity.HasIndex(e => e.ItemId);

                entity.HasIndex(e => e.ModifiedBy);

                entity.HasIndex(e => e.OrderInterestedNoteId);

                entity.Property(e => e.ExpeditorReasonNotTake).HasMaxLength(200);

                entity.Property(e => e.Note).HasMaxLength(200);

                entity.Property(e => e.OrderStatusNote).HasMaxLength(200);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.OrdersCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CustomerAdress)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerAdressId);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.DriverId);

                entity.HasOne(d => d.InfSource)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.InfSourceId);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ItemId);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.OrdersModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);

                entity.HasOne(d => d.OrderInterestedNote)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderInterestedNoteId);
            });

            modelBuilder.Entity<OrdersFor1c>(entity =>
            {
                entity.ToTable("ORDERS_FOR1C", "dbo");

                entity.Property(e => e.Address).HasColumnName("ADDRESS");

                entity.Property(e => e.ClientUnicId).HasColumnName("CLIENT_UNIC_ID");

                entity.Property(e => e.ExpeditorName).HasColumnName("EXPEDITOR_NAME");

                entity.Property(e => e.Item).HasColumnName("ITEM");

                entity.Property(e => e.ItemAmount).HasColumnName("ITEM_AMOUNT");

                entity.Property(e => e.ItemDiscount).HasColumnName("ITEM_DISCOUNT");

                entity.Property(e => e.ItemLength).HasColumnName("ITEM_LENGTH");

                entity.Property(e => e.ItemPrice).HasColumnName("ITEM_PRICE");

                entity.Property(e => e.ItemQty).HasColumnName("ITEM_QTY");

                entity.Property(e => e.ItemWidth).HasColumnName("ITEM_WIDTH");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("ORDER_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");

                entity.Property(e => e.OrderStatus).HasColumnName("ORDER_STATUS");

                entity.Property(e => e.OrderUnicId).HasColumnName("ORDER_UNIC_ID");

                entity.Property(e => e.Service).HasColumnName("SERVICE");

                entity.Property(e => e.SubItem).HasColumnName("SUB_ITEM");
            });

            modelBuilder.Entity<Pivot2022>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pivot_2022", "dbo");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Day)
                    .HasColumnName("DAY")
                    .HasMaxLength(255);

                entity.Property(e => e.Item)
                    .HasColumnName("ITEM")
                    .HasMaxLength(255);

                entity.Property(e => e.Month).HasColumnName("MONTH");

                entity.Property(e => e.Year)
                    .HasColumnName("YEAR")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<RefreshTokens>(entity =>
            {
                entity.ToTable("RefreshTokens", "dbo");

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.AccessToken).IsUnicode(false);

                entity.Property(e => e.Expires).HasColumnType("datetime");

                entity.Property(e => e.Issued).HasColumnType("datetime");

                entity.Property(e => e.Token).IsUnicode(false);

                entity.Property(e => e.TokenExpires).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RefreshTokens)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ReporUserRoleMapping>(entity =>
            {
                entity.ToTable("ReporUserRoleMapping", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ReportRoleId).HasColumnName("REPORT_ROLE_ID");

                entity.Property(e => e.ReportUserId).HasColumnName("REPORT_USER_ID");

                entity.HasOne(d => d.ReportRole)
                    .WithMany(p => p.ReporUserRoleMapping)
                    .HasForeignKey(d => d.ReportRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FOREIGNKEY_REPORT_USER_ROLE_MAPPING_ROLE_ID");

                entity.HasOne(d => d.ReportUser)
                    .WithMany(p => p.ReporUserRoleMapping)
                    .HasForeignKey(d => d.ReportUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FOREIGNKEY_REPORT_USER_ROLE_MAPPING_USER_ID");
            });

            modelBuilder.Entity<ReportCdr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ReportCdr", "dbo");

                entity.HasIndex(e => e.Dst)
                    .HasName("index_dst");

                entity.HasIndex(e => e.Dstname)
                    .HasName("index_dstname");

                entity.HasIndex(e => e.Recordfile)
                    .HasName("index_recordfile");

                entity.HasIndex(e => e.Src)
                    .HasName("index_src");

                entity.HasIndex(e => e.Srcname)
                    .HasName("index_srcname");

                entity.HasIndex(e => e.Timestamp)
                    .HasName("index_timestamp");

                entity.HasIndex(e => e.Uid)
                    .HasName("cdr_uid_IDX");

                entity.HasIndex(e => e.Uniqueid)
                    .HasName("index_uniqueid");

                entity.Property(e => e.Accountcode)
                    .IsRequired()
                    .HasColumnName("accountcode")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Amaflags).HasColumnName("amaflags");

                entity.Property(e => e.Calltype)
                    .IsRequired()
                    .HasColumnName("calltype")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasColumnName("channel")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Clid)
                    .HasColumnName("clid")
                    .HasMaxLength(80);

                entity.Property(e => e.Concurrentcalls).HasColumnName("concurrentcalls");

                entity.Property(e => e.Datetime).HasColumnName("datetime");

                entity.Property(e => e.Dcontext)
                    .IsRequired()
                    .HasColumnName("dcontext")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Didnumber)
                    .IsRequired()
                    .HasColumnName("didnumber")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Displayonweb).HasColumnName("displayonweb");

                entity.Property(e => e.Disposition)
                    .IsRequired()
                    .HasColumnName("disposition")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Dodnumber)
                    .IsRequired()
                    .HasColumnName("dodnumber")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Dst)
                    .IsRequired()
                    .HasColumnName("dst")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DstDelCdr).HasColumnName("dst_del_cdr");

                entity.Property(e => e.DstDelRecording).HasColumnName("dst_del_recording");

                entity.Property(e => e.Dstchannel)
                    .IsRequired()
                    .HasColumnName("dstchannel")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Dstchanurl)
                    .IsRequired()
                    .HasColumnName("dstchanurl")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Dstname)
                    .HasColumnName("dstname")
                    .HasMaxLength(128);

                entity.Property(e => e.Dstnameprefix)
                    .IsRequired()
                    .HasColumnName("dstnameprefix")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Dsttrunk)
                    .IsRequired()
                    .HasColumnName("dsttrunk")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.In2outbound).HasColumnName("in2outbound");

                entity.Property(e => e.Lastapp)
                    .IsRequired()
                    .HasColumnName("lastapp")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Lastdata)
                    .IsRequired()
                    .HasColumnName("lastdata")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.MisscallIsread).HasColumnName("misscall_isread");

                entity.Property(e => e.Rascall).HasColumnName("rascall");

                entity.Property(e => e.RateId).HasColumnName("rate_id");

                entity.Property(e => e.Reasonpartya)
                    .IsRequired()
                    .HasColumnName("reasonpartya")
                    .HasMaxLength(180)
                    .IsUnicode(false);

                entity.Property(e => e.Reasonpartyb)
                    .IsRequired()
                    .HasColumnName("reasonpartyb")
                    .HasMaxLength(180)
                    .IsUnicode(false);

                entity.Property(e => e.Reasonpartyc)
                    .IsRequired()
                    .HasColumnName("reasonpartyc")
                    .HasMaxLength(180)
                    .IsUnicode(false);

                entity.Property(e => e.Reasonpartyd)
                    .IsRequired()
                    .HasColumnName("reasonpartyd")
                    .HasMaxLength(180)
                    .IsUnicode(false);

                entity.Property(e => e.Reasonpartye)
                    .IsRequired()
                    .HasColumnName("reasonpartye")
                    .HasMaxLength(180)
                    .IsUnicode(false);

                entity.Property(e => e.Reasonpartyf)
                    .IsRequired()
                    .HasColumnName("reasonpartyf")
                    .HasMaxLength(180)
                    .IsUnicode(false);

                entity.Property(e => e.Recordfile)
                    .IsRequired()
                    .HasColumnName("recordfile")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Recordpath)
                    .IsRequired()
                    .HasColumnName("recordpath")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Ringduration).HasColumnName("ringduration");

                entity.Property(e => e.Src)
                    .IsRequired()
                    .HasColumnName("src")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SrcDelCdr).HasColumnName("src_del_cdr");

                entity.Property(e => e.SrcDelRecording).HasColumnName("src_del_recording");

                entity.Property(e => e.Srcaddr)
                    .IsRequired()
                    .HasColumnName("srcaddr")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Srcchanurl)
                    .IsRequired()
                    .HasColumnName("srcchanurl")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Srcname)
                    .IsRequired()
                    .HasColumnName("srcname")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Srcnameprefix)
                    .IsRequired()
                    .HasColumnName("srcnameprefix")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Srctrunk)
                    .IsRequired()
                    .HasColumnName("srctrunk")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Talkduration).HasColumnName("talkduration");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");

                entity.Property(e => e.Tryvideocall).HasColumnName("tryvideocall");

                entity.Property(e => e.Uid)
                    .IsRequired()
                    .HasColumnName("uid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Uniqueid)
                    .IsRequired()
                    .HasColumnName("uniqueid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Videocall).HasColumnName("videocall");
            });

            modelBuilder.Entity<ReportCdrTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ReportCdrTemp", "dbo");

                entity.Property(e => e.Accountcode)
                    .IsRequired()
                    .HasColumnName("accountcode")
                    .HasMaxLength(128);

                entity.Property(e => e.Amaflags).HasColumnName("amaflags");

                entity.Property(e => e.Calltype)
                    .IsRequired()
                    .HasColumnName("calltype")
                    .HasMaxLength(32);

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasColumnName("channel")
                    .HasMaxLength(80);

                entity.Property(e => e.Clid)
                    .IsRequired()
                    .HasColumnName("clid")
                    .HasMaxLength(80);

                entity.Property(e => e.Concurrentcalls).HasColumnName("concurrentcalls");

                entity.Property(e => e.Datetime).HasColumnName("datetime");

                entity.Property(e => e.Dcontext)
                    .IsRequired()
                    .HasColumnName("dcontext")
                    .HasMaxLength(80);

                entity.Property(e => e.Didnumber)
                    .IsRequired()
                    .HasColumnName("didnumber")
                    .HasMaxLength(64);

                entity.Property(e => e.Displayonweb).HasColumnName("displayonweb");

                entity.Property(e => e.Disposition)
                    .IsRequired()
                    .HasColumnName("disposition")
                    .HasMaxLength(60);

                entity.Property(e => e.Dodnumber)
                    .IsRequired()
                    .HasColumnName("dodnumber")
                    .HasMaxLength(64);

                entity.Property(e => e.Dst)
                    .IsRequired()
                    .HasColumnName("dst")
                    .HasMaxLength(80);

                entity.Property(e => e.DstDelCdr).HasColumnName("dst_del_cdr");

                entity.Property(e => e.DstDelRecording).HasColumnName("dst_del_recording");

                entity.Property(e => e.Dstchannel)
                    .IsRequired()
                    .HasColumnName("dstchannel")
                    .HasMaxLength(80);

                entity.Property(e => e.Dstchanurl)
                    .IsRequired()
                    .HasColumnName("dstchanurl")
                    .HasMaxLength(128);

                entity.Property(e => e.Dstname)
                    .IsRequired()
                    .HasColumnName("dstname")
                    .HasMaxLength(128);

                entity.Property(e => e.Dstnameprefix)
                    .IsRequired()
                    .HasColumnName("dstnameprefix")
                    .HasMaxLength(32);

                entity.Property(e => e.Dsttrunk)
                    .IsRequired()
                    .HasColumnName("dsttrunk")
                    .HasMaxLength(80);

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.In2outbound).HasColumnName("in2outbound");

                entity.Property(e => e.Lastapp)
                    .IsRequired()
                    .HasColumnName("lastapp")
                    .HasMaxLength(80);

                entity.Property(e => e.Lastdata)
                    .IsRequired()
                    .HasColumnName("lastdata")
                    .HasMaxLength(80);

                entity.Property(e => e.MisscallIsread).HasColumnName("misscall_isread");

                entity.Property(e => e.Rascall).HasColumnName("rascall");

                entity.Property(e => e.RateId).HasColumnName("rate_id");

                entity.Property(e => e.Reasonpartya)
                    .IsRequired()
                    .HasColumnName("reasonpartya")
                    .HasMaxLength(180);

                entity.Property(e => e.Reasonpartyb)
                    .IsRequired()
                    .HasColumnName("reasonpartyb")
                    .HasMaxLength(180);

                entity.Property(e => e.Reasonpartyc)
                    .IsRequired()
                    .HasColumnName("reasonpartyc")
                    .HasMaxLength(180);

                entity.Property(e => e.Reasonpartyd)
                    .IsRequired()
                    .HasColumnName("reasonpartyd")
                    .HasMaxLength(180);

                entity.Property(e => e.Reasonpartye)
                    .IsRequired()
                    .HasColumnName("reasonpartye")
                    .HasMaxLength(180);

                entity.Property(e => e.Reasonpartyf)
                    .IsRequired()
                    .HasColumnName("reasonpartyf")
                    .HasMaxLength(180);

                entity.Property(e => e.Recordfile)
                    .IsRequired()
                    .HasColumnName("recordfile")
                    .HasMaxLength(128);

                entity.Property(e => e.Recordpath)
                    .IsRequired()
                    .HasColumnName("recordpath")
                    .HasMaxLength(256);

                entity.Property(e => e.Ringduration).HasColumnName("ringduration");

                entity.Property(e => e.Src)
                    .IsRequired()
                    .HasColumnName("src")
                    .HasMaxLength(80);

                entity.Property(e => e.SrcDelCdr).HasColumnName("src_del_cdr");

                entity.Property(e => e.SrcDelRecording).HasColumnName("src_del_recording");

                entity.Property(e => e.Srcaddr)
                    .IsRequired()
                    .HasColumnName("srcaddr")
                    .HasMaxLength(80);

                entity.Property(e => e.Srcchanurl)
                    .IsRequired()
                    .HasColumnName("srcchanurl")
                    .HasMaxLength(128);

                entity.Property(e => e.Srcname)
                    .IsRequired()
                    .HasColumnName("srcname")
                    .HasMaxLength(128);

                entity.Property(e => e.Srcnameprefix)
                    .IsRequired()
                    .HasColumnName("srcnameprefix")
                    .HasMaxLength(32);

                entity.Property(e => e.Srctrunk)
                    .IsRequired()
                    .HasColumnName("srctrunk")
                    .HasMaxLength(80);

                entity.Property(e => e.Talkduration).HasColumnName("talkduration");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");

                entity.Property(e => e.Tryvideocall).HasColumnName("tryvideocall");

                entity.Property(e => e.Uid)
                    .IsRequired()
                    .HasColumnName("uid")
                    .HasMaxLength(32);

                entity.Property(e => e.Uniqueid)
                    .IsRequired()
                    .HasColumnName("uniqueid")
                    .HasMaxLength(32);

                entity.Property(e => e.Videocall).HasColumnName("videocall");
            });

            modelBuilder.Entity<ReportIgnoredNumbers>(entity =>
            {
                entity.ToTable("ReportIgnoredNumbers", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("CREATE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Phone)
                    .HasColumnName("PHONE")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ReportRole>(entity =>
            {
                entity.ToTable("ReportRole", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(100);

                entity.Property(e => e.MenuGroup)
                    .HasColumnName("MENU_GROUP")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ReportUser>(entity =>
            {
                entity.ToTable("ReportUser", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Createdate)
                    .HasColumnName("CREATEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(100);

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("FIRSTNAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("LASTNAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.ToTable("Roles", "dbo");

                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<SqlerrorLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SQLErrorLog", "dbo");

                entity.Property(e => e.LogDate).HasColumnType("datetime");

                entity.Property(e => e.ProcessInfo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Text)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StartWorkLog>(entity =>
            {
                entity.ToTable("StartWorkLog", "dbo");

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.HasIndex(e => new { e.DriverName, e.CarNumber, e.Assistant, e.Reserve, e.ModuleType, e.CreateShortDate })
                    .IsUnique();

                entity.Property(e => e.Assistant).HasMaxLength(50);

                entity.Property(e => e.CarNumber).HasMaxLength(10);

                entity.Property(e => e.CreateShortDate).HasColumnType("date");

                entity.Property(e => e.DriverName).HasMaxLength(50);

                entity.Property(e => e.Reserve).HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.StartWorkLogCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.StartWorkLogModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<Streets>(entity =>
            {
                entity.ToTable("Streets", "dbo");

                entity.HasIndex(e => e.DistrictId);

                entity.HasIndex(e => e.Name)
                    .IsUnique();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Streets)
                    .HasForeignKey(d => d.DistrictId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<SubItems>(entity =>
            {
                entity.ToTable("SubItems", "dbo");

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ItemId);

                entity.HasIndex(e => e.ModifiedBy);

                entity.HasIndex(e => new { e.Name, e.ItemId })
                    .IsUnique();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SubItemsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.SubItems)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SubItemsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<Test123>(entity =>
            {
                entity.HasKey(e => e.LogicalRef)
                    .HasName("pk_LOGICAL_REF");

                entity.ToTable("test123", "dbo");

                entity.Property(e => e.LogicalRef)
                    .HasColumnName("LOGICAL_REF")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tarix).HasColumnType("datetime");
            });

            modelBuilder.Entity<Test41>(entity =>
            {
                entity.HasKey(e => e.Logicalref);

                entity.ToTable("test41", "dbo");

                entity.Property(e => e.Logicalref).HasColumnName("LOGICALREF");

                entity.Property(e => e.Modul).HasColumnName("MODUL");

                entity.Property(e => e.Tip).HasColumnName("TIP");
            });

            modelBuilder.Entity<UserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.ToTable("UserRoles", "dbo");

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("Users", "dbo");

                entity.HasIndex(e => e.ModifiedBy);

                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.PhoneNumber).HasMaxLength(21);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.InverseModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<Villages>(entity =>
            {
                entity.ToTable("Villages", "dbo");

                entity.HasIndex(e => e.Name)
                    .IsUnique();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<VwHesabatDovriyyeDetail2023>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_HesabatDovriyye_Detail_2023", "dbo");

                entity.Property(e => e.Məhsul)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<VwPivotKvadratHesabati>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Pivot_Kvadrat_Hesabati", "dbo");

                entity.Property(e => e.Nov)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZOperatorOp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_OPERATOR_OP", "dbo");

                entity.Property(e => e.Confirm).HasColumnName("CONFIRM");

                entity.Property(e => e.ExpeditorName)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.Gün).HasColumnName("gün");

                entity.Property(e => e.Il).HasColumnName("il");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OperatorName)
                    .IsRequired()
                    .HasMaxLength(75);
            });

            modelBuilder.Entity<ZReport2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_REPORT_2", "dbo");

                entity.Property(e => e.AdditionalNote).HasMaxLength(200);

                entity.Property(e => e.CallResult)
                    .IsRequired()
                    .HasMaxLength(24);

                entity.Property(e => e.ClientFeedback)
                    .IsRequired()
                    .HasMaxLength(18);

                entity.Property(e => e.ExpeditorName)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.FactNo).HasMaxLength(40);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(125);

                entity.Property(e => e.HomeNumber).HasMaxLength(21);

                entity.Property(e => e.LateDeliveryService)
                    .IsRequired()
                    .HasMaxLength(14);

                entity.Property(e => e.NoAnswerNote)
                    .HasColumnName("noAnswerNote")
                    .HasMaxLength(200);

                entity.Property(e => e.OperatorNote).HasMaxLength(200);

                entity.Property(e => e.OrderChecked)
                    .IsRequired()
                    .HasMaxLength(14);

                entity.Property(e => e.PhoneNumber1)
                    .IsRequired()
                    .HasMaxLength(21);

                entity.Property(e => e.PhoneNumber2).HasMaxLength(21);

                entity.Property(e => e.QualityControlAssessmentNote).HasMaxLength(200);

                entity.Property(e => e.ServiceNote).HasMaxLength(200);
            });

            modelBuilder.Entity<ZReportOp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_REPORT_OP", "dbo");

                entity.Property(e => e.CustName)
                    .IsRequired()
                    .HasColumnName("CUST_NAME")
                    .HasMaxLength(125);

                entity.Property(e => e.ExpeditorName)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.FactNo)
                    .IsRequired()
                    .HasMaxLength(22);

                entity.Property(e => e.ItemAmount).HasColumnName("ITEM_AMOUNT");

                entity.Property(e => e.ItemDiscount).HasColumnName("ITEM_DISCOUNT");

                entity.Property(e => e.ItemLastAmount).HasColumnName("ITEM_LAST_AMOUNT");

                entity.Property(e => e.ItemLength).HasColumnName("ITEM_LENGTH");

                entity.Property(e => e.ItemName)
                    .HasColumnName("ITEM_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.ItemPrice).HasColumnName("ITEM_PRICE");

                entity.Property(e => e.ItemWidth).HasColumnName("ITEM_WIDTH");

                entity.Property(e => e.SubItemName)
                    .HasColumnName("SUB_ITEM_NAME")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<_1c>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("1C", "dbo");

                entity.Property(e => e.Bina)
                    .HasColumnName("BINA")
                    .HasMaxLength(200);

                entity.Property(e => e.Blok)
                    .HasColumnName("BLOK")
                    .HasMaxLength(200);

                entity.Property(e => e.Clientadress1)
                    .HasColumnName("CLIENTADRESS1")
                    .HasMaxLength(250);

                entity.Property(e => e.Clientadress2)
                    .HasColumnName("CLIENTADRESS2")
                    .HasMaxLength(250);

                entity.Property(e => e.Clientname)
                    .HasColumnName("CLIENTNAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Clientunicid)
                    .HasColumnName("CLIENTUNICID")
                    .HasMaxLength(50);

                entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");

                entity.Property(e => e.Expeditorid)
                    .HasColumnName("EXPEDITORID")
                    .HasMaxLength(20);

                entity.Property(e => e.Expeditorname)
                    .HasColumnName("EXPEDITORNAME")
                    .HasMaxLength(150);

                entity.Property(e => e.Expeditorunicid)
                    .HasColumnName("EXPEDITORUNICID")
                    .HasMaxLength(150);

                entity.Property(e => e.Itemamount)
                    .HasColumnName("ITEMAMOUNT")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Itemdiscountsum)
                    .HasColumnName("ITEMDISCOUNTSUM")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Itemfinalsum)
                    .HasColumnName("ITEMFINALSUM")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Itemid)
                    .HasColumnName("ITEMID")
                    .HasMaxLength(50);

                entity.Property(e => e.Itemlength)
                    .HasColumnName("ITEMLENGTH")
                    .HasColumnType("decimal(15, 3)");

                entity.Property(e => e.Itemname)
                    .HasColumnName("ITEMNAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Itemprice)
                    .HasColumnName("ITEMPRICE")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Itemqty)
                    .HasColumnName("ITEMQTY")
                    .HasColumnType("decimal(15, 3)");

                entity.Property(e => e.Itemunicid)
                    .HasColumnName("ITEMUNICID")
                    .HasMaxLength(50);

                entity.Property(e => e.Itemvatpercentage)
                    .HasColumnName("ITEMVATPERCENTAGE")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Itemvatsum)
                    .HasColumnName("ITEMVATSUM")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Itemwidth)
                    .HasColumnName("ITEMWIDTH")
                    .HasColumnType("decimal(15, 3)");

                entity.Property(e => e.Kuce)
                    .HasColumnName("KUCE")
                    .HasMaxLength(200);

                entity.Property(e => e.Menzil)
                    .HasColumnName("MENZIL")
                    .HasMaxLength(200);

                entity.Property(e => e.Mertebe)
                    .HasColumnName("MERTEBE")
                    .HasMaxLength(200);

                entity.Property(e => e.Mobile2areacode)
                    .HasColumnName("MOBILE2AREACODE")
                    .HasMaxLength(5);

                entity.Property(e => e.Mobile2countrycode)
                    .HasColumnName("MOBILE2COUNTRYCODE")
                    .HasMaxLength(5);

                entity.Property(e => e.Mobile2number)
                    .HasColumnName("MOBILE2NUMBER")
                    .HasMaxLength(20);

                entity.Property(e => e.Mobileareacode)
                    .HasColumnName("MOBILEAREACODE")
                    .HasMaxLength(5);

                entity.Property(e => e.Mobilecountrycode)
                    .HasColumnName("MOBILECOUNTRYCODE")
                    .HasMaxLength(5);

                entity.Property(e => e.Mobilenumber)
                    .HasColumnName("MOBILENUMBER")
                    .HasMaxLength(20);

                entity.Property(e => e.Note)
                    .HasColumnName("NOTE")
                    .HasMaxLength(250);

                entity.Property(e => e.Orderdate)
                    .HasColumnName("ORDERDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Orderid)
                    .HasColumnName("ORDERID")
                    .HasMaxLength(50);

                entity.Property(e => e.Orderstatus)
                    .HasColumnName("ORDERSTATUS")
                    .HasMaxLength(50);

                entity.Property(e => e.Orderunicid)
                    .HasColumnName("ORDERUNICID")
                    .HasMaxLength(50);

                entity.Property(e => e.Phoneareacode)
                    .HasColumnName("PHONEAREACODE")
                    .HasMaxLength(5);

                entity.Property(e => e.Phonecountrycode)
                    .HasColumnName("PHONECOUNTRYCODE")
                    .HasMaxLength(5);

                entity.Property(e => e.Phonenumber)
                    .HasColumnName("PHONENUMBER")
                    .HasMaxLength(20);

                entity.Property(e => e.Rayon)
                    .HasColumnName("RAYON")
                    .HasMaxLength(200);

                entity.Property(e => e.Seher)
                    .HasColumnName("SEHER")
                    .HasMaxLength(50);

                entity.Property(e => e.Statusdatetime)
                    .HasColumnName("STATUSDATETIME")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<_1cCopy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("1C_COPY", "dbo");

                entity.Property(e => e.Clientadress1)
                    .HasColumnName("CLIENTADRESS1")
                    .HasMaxLength(250);

                entity.Property(e => e.Clientadress2)
                    .HasColumnName("CLIENTADRESS2")
                    .HasMaxLength(250);

                entity.Property(e => e.Clientname)
                    .HasColumnName("CLIENTNAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Clientunicid)
                    .HasColumnName("CLIENTUNICID")
                    .HasMaxLength(50);

                entity.Property(e => e.Expeditorid)
                    .HasColumnName("EXPEDITORID")
                    .HasMaxLength(20);

                entity.Property(e => e.Expeditorname)
                    .HasColumnName("EXPEDITORNAME")
                    .HasMaxLength(150);

                entity.Property(e => e.Expeditorunicid)
                    .HasColumnName("EXPEDITORUNICID")
                    .HasMaxLength(150);

                entity.Property(e => e.Itemamount)
                    .HasColumnName("ITEMAMOUNT")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Itemdiscountsum)
                    .HasColumnName("ITEMDISCOUNTSUM")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Itemfinalsum)
                    .HasColumnName("ITEMFINALSUM")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Itemid)
                    .HasColumnName("ITEMID")
                    .HasMaxLength(50);

                entity.Property(e => e.Itemlength)
                    .HasColumnName("ITEMLENGTH")
                    .HasColumnType("decimal(15, 3)");

                entity.Property(e => e.Itemname)
                    .HasColumnName("ITEMNAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Itemprice)
                    .HasColumnName("ITEMPRICE")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Itemqty)
                    .HasColumnName("ITEMQTY")
                    .HasColumnType("decimal(15, 3)");

                entity.Property(e => e.Itemunicid)
                    .HasColumnName("ITEMUNICID")
                    .HasMaxLength(50);

                entity.Property(e => e.Itemvatpercentage)
                    .HasColumnName("ITEMVATPERCENTAGE")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Itemvatsum)
                    .HasColumnName("ITEMVATSUM")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Itemwidth)
                    .HasColumnName("ITEMWIDTH")
                    .HasColumnType("decimal(15, 3)");

                entity.Property(e => e.Mobile2areacode)
                    .HasColumnName("MOBILE2AREACODE")
                    .HasMaxLength(5);

                entity.Property(e => e.Mobile2countrycode)
                    .HasColumnName("MOBILE2COUNTRYCODE")
                    .HasMaxLength(5);

                entity.Property(e => e.Mobile2number)
                    .HasColumnName("MOBILE2NUMBER")
                    .HasMaxLength(20);

                entity.Property(e => e.Mobileareacode)
                    .HasColumnName("MOBILEAREACODE")
                    .HasMaxLength(5);

                entity.Property(e => e.Mobilecountrycode)
                    .HasColumnName("MOBILECOUNTRYCODE")
                    .HasMaxLength(5);

                entity.Property(e => e.Mobilenumber)
                    .HasColumnName("MOBILENUMBER")
                    .HasMaxLength(20);

                entity.Property(e => e.Note)
                    .HasColumnName("NOTE")
                    .HasMaxLength(250);

                entity.Property(e => e.Orderdate)
                    .HasColumnName("ORDERDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Orderid)
                    .HasColumnName("ORDERID")
                    .HasMaxLength(50);

                entity.Property(e => e.Orderstatus)
                    .HasColumnName("ORDERSTATUS")
                    .HasMaxLength(50);

                entity.Property(e => e.Orderunicid)
                    .HasColumnName("ORDERUNICID")
                    .HasMaxLength(50);

                entity.Property(e => e.Phoneareacode)
                    .HasColumnName("PHONEAREACODE")
                    .HasMaxLength(5);

                entity.Property(e => e.Phonecountrycode)
                    .HasColumnName("PHONECOUNTRYCODE")
                    .HasMaxLength(5);

                entity.Property(e => e.Phonenumber)
                    .HasColumnName("PHONENUMBER")
                    .HasMaxLength(20);

                entity.Property(e => e.Statusdatetime)
                    .HasColumnName("STATUSDATETIME")
                    .HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
