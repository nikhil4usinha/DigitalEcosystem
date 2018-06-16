using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DatabaseEF.Models
{
    public partial class DigitalEcoSystemContext : DbContext
    {
        public DigitalEcoSystemContext()
        {
        }

        public DigitalEcoSystemContext(DbContextOptions<DigitalEcoSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DealerVehicleAcceptStatusEvent> DealerVehicleAcceptStatusEvent { get; set; }
        public virtual DbSet<OrderStatusEvent> OrderStatusEvent { get; set; }
        public virtual DbSet<VehicleAccessories> VehicleAccessories { get; set; }
        public virtual DbSet<VehicleAllocationToDealers> VehicleAllocationToDealers { get; set; }
        public virtual DbSet<VehicleConfig> VehicleConfig { get; set; }
        public virtual DbSet<VehicleForecasting> VehicleForecasting { get; set; }
        public virtual DbSet<VehicleInventory> VehicleInventory { get; set; }
        public virtual DbSet<VehicleInvoice> VehicleInvoice { get; set; }
        public virtual DbSet<VehicleLogistics> VehicleLogistics { get; set; }
        public virtual DbSet<VehicleOrders> VehicleOrders { get; set; }
        public virtual DbSet<VehicleSales> VehicleSales { get; set; }
        public virtual DbSet<VehicleStatusEvent> VehicleStatusEvent { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=10.228.102.9;Database=DigitalEcoSystem;Persist Security Info=False;User ID=sa;Password=Password@123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DealerVehicleAcceptStatusEvent>(entity =>
            {
                entity.HasKey(e => e.DealerVehicleStatusId);

                entity.Property(e => e.DealerVehicleStatusId).HasColumnName("DealerVehicleStatusID");

                entity.Property(e => e.DealerCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.TempVin)
                    .IsRequired()
                    .HasColumnName("TempVIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleConfigId).HasColumnName("VehicleConfigID");

                entity.Property(e => e.VehicleStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.VehicleConfig)
                    .WithMany(p => p.DealerVehicleAcceptStatusEvent)
                    .HasForeignKey(d => d.VehicleConfigId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DealerVehicleAcceptStatusEvent_VehicleConfig");
            });

            modelBuilder.Entity<OrderStatusEvent>(entity =>
            {
                entity.HasKey(e => e.OrderStatusId);

                entity.Property(e => e.OrderStatusId).HasColumnName("OrderStatusID");

                entity.Property(e => e.DistributorId).HasColumnName("DistributorID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessDateTime).HasColumnType("datetime");

                entity.Property(e => e.VehicleOrdersId).HasColumnName("VehicleOrdersID");

                entity.HasOne(d => d.VehicleOrders)
                    .WithMany(p => p.OrderStatusEvent)
                    .HasForeignKey(d => d.VehicleOrdersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderStatusEvent_VehicleOrders");
            });

            modelBuilder.Entity<VehicleAccessories>(entity =>
            {
                entity.Property(e => e.VehicleAccessoriesId).HasColumnName("VehicleAccessoriesID");

                entity.Property(e => e.CarpetMats)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DealerCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ledlights)
                    .HasColumnName("LEDLights")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PhoneCableChargePackage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempVin)
                    .IsRequired()
                    .HasColumnName("TempVIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleConfigId).HasColumnName("VehicleConfigID");

                entity.Property(e => e.VehicleModel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.VehicleConfig)
                    .WithMany(p => p.VehicleAccessories)
                    .HasForeignKey(d => d.VehicleConfigId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleAccessories_VehicleConfig");
            });

            modelBuilder.Entity<VehicleAllocationToDealers>(entity =>
            {
                entity.HasKey(e => e.VehicleAllocationId);

                entity.Property(e => e.VehicleAllocationId).HasColumnName("VehicleAllocationID");

                entity.Property(e => e.DealerCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorId).HasColumnName("DistributorID");

                entity.Property(e => e.EstimatedDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.TempVin)
                    .IsRequired()
                    .HasColumnName("TempVIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleConfigId).HasColumnName("VehicleConfigID");

                entity.Property(e => e.VehicleModel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.VehicleConfig)
                    .WithMany(p => p.VehicleAllocationToDealers)
                    .HasForeignKey(d => d.VehicleConfigId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleAllocationToDealers_VehicleConfig");
            });

            modelBuilder.Entity<VehicleConfig>(entity =>
            {
                entity.Property(e => e.VehicleConfigId).HasColumnName("VehicleConfigID");

                entity.Property(e => e.EstimatedDeliverydate).HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderLineId).HasColumnName("OrderLineID");

                entity.Property(e => e.ProcessDateTime).HasColumnType("datetime");

                entity.Property(e => e.TempVinid)
                    .IsRequired()
                    .HasColumnName("TempVINID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleModel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleOrdersId).HasColumnName("VehicleOrdersID");

                entity.HasOne(d => d.VehicleOrders)
                    .WithMany(p => p.VehicleConfig)
                    .HasForeignKey(d => d.VehicleOrdersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleConfig_VehicleOrders");
            });

            modelBuilder.Entity<VehicleForecasting>(entity =>
            {
                entity.Property(e => e.VehicleForecastingId).HasColumnName("VehicleForecastingID");

                entity.Property(e => e.DistributorId).HasColumnName("DistributorID");

                entity.Property(e => e.DistributorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EstimatedDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderLineId).HasColumnName("OrderLineID");

                entity.Property(e => e.ProcessDateTime).HasColumnType("datetime");

                entity.Property(e => e.VehicleModel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleOrdersId).HasColumnName("VehicleOrdersID");

                entity.HasOne(d => d.VehicleOrders)
                    .WithMany(p => p.VehicleForecasting)
                    .HasForeignKey(d => d.VehicleOrdersId)
                    .HasConstraintName("FK_VehicleForecasting_VehicleOrders");
            });

            modelBuilder.Entity<VehicleInventory>(entity =>
            {
                entity.Property(e => e.VehicleInventoryId).HasColumnName("VehicleInventoryID");

                entity.Property(e => e.EstimatedDeliverydate).HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderLineId).HasColumnName("OrderLineID");

                entity.Property(e => e.ProcessDateTime).HasColumnType("datetime");

                entity.Property(e => e.TempVin)
                    .IsRequired()
                    .HasColumnName("TempVIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleModel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleOrdersId).HasColumnName("VehicleOrdersID");

                entity.HasOne(d => d.VehicleOrders)
                    .WithMany(p => p.VehicleInventory)
                    .HasForeignKey(d => d.VehicleOrdersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleInventory_VehicleOrders");
            });

            modelBuilder.Entity<VehicleInvoice>(entity =>
            {
                entity.Property(e => e.VehicleInvoiceId).HasColumnName("VehicleInvoiceID");

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.DistributorId).HasColumnName("DistributorID");

                entity.Property(e => e.InvoiceAmount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.TempVin)
                    .IsRequired()
                    .HasColumnName("TempVIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleLogisticsId).HasColumnName("VehicleLogisticsID");

                entity.Property(e => e.VehicleModel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehiclePrice)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vin)
                    .IsRequired()
                    .HasColumnName("VIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.VehicleLogistics)
                    .WithMany(p => p.VehicleInvoice)
                    .HasForeignKey(d => d.VehicleLogisticsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleInvoice_VehicleLogistics");
            });

            modelBuilder.Entity<VehicleLogistics>(entity =>
            {
                entity.Property(e => e.VehicleLogisticsId).HasColumnName("VehicleLogisticsID");

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.DistributorId).HasColumnName("DistributorID");

                entity.Property(e => e.InvoiceAmount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.TempVin)
                    .IsRequired()
                    .HasColumnName("TempVIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleConfigId).HasColumnName("VehicleConfigID");

                entity.Property(e => e.VehicleModel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vin)
                    .IsRequired()
                    .HasColumnName("VIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.VehicleConfig)
                    .WithMany(p => p.VehicleLogistics)
                    .HasForeignKey(d => d.VehicleConfigId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleLogistics_VehicleConfig");
            });

            modelBuilder.Entity<VehicleOrders>(entity =>
            {
                entity.Property(e => e.VehicleOrdersId).HasColumnName("VehicleOrdersID");

                entity.Property(e => e.DistributorId).HasColumnName("DistributorID");

                entity.Property(e => e.DistributorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EstimatedDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderLineId).HasColumnName("OrderLineID");

                entity.Property(e => e.ProcessDateTime).HasColumnType("datetime");

                entity.Property(e => e.VehicleModel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VehicleSales>(entity =>
            {
                entity.HasKey(e => e.VehicleSaleId);

                entity.Property(e => e.VehicleSaleId).HasColumnName("VehicleSaleID");

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Discount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorId).HasColumnName("DistributorID");

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SaleDate).HasColumnType("datetime");

                entity.Property(e => e.SalePrice)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleLogisticsId).HasColumnName("VehicleLogisticsID");

                entity.Property(e => e.Vin)
                    .IsRequired()
                    .HasColumnName("VIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.VehicleLogistics)
                    .WithMany(p => p.VehicleSales)
                    .HasForeignKey(d => d.VehicleLogisticsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleSales_VehicleLogistics");
            });

            modelBuilder.Entity<VehicleStatusEvent>(entity =>
            {
                entity.HasKey(e => e.VehicleStatusId);

                entity.Property(e => e.VehicleStatusId).HasColumnName("VehicleStatusID");

                entity.Property(e => e.DistributorId).HasColumnName("DistributorID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.VehicleLogisticsId).HasColumnName("VehicleLogisticsID");

                entity.Property(e => e.Vin)
                    .IsRequired()
                    .HasColumnName("VIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vinstatus)
                    .HasColumnName("VINStatus")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.VehicleLogistics)
                    .WithMany(p => p.VehicleStatusEvent)
                    .HasForeignKey(d => d.VehicleLogisticsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleStatusEvent_VehicleLogistics");
            });
        }
    }
}
