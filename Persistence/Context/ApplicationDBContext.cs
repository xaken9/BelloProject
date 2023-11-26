using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Persistence.Context
{
    public partial class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext()
        {
        }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Branch> Branches { get; set; }

        public virtual DbSet<CreditNote> CreditNotes { get; set; }

        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<DebitNote> DebitNotes { get; set; }

        public virtual DbSet<DeliveryOrder> DeliveryOrders { get; set; }

        public virtual DbSet<Invoice> Invoices { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<Quotation> Quotations { get; set; }

        public virtual DbSet<Receipt> Receipts { get; set; }

        public virtual DbSet<SalesOrder> SalesOrders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=BDatabase;Trusted_Connection=True;TrustServerCertificate=true;User ID=sa;Password=abc123",                    
                    x => x.MigrationsHistoryTable("_EFMigrationsHistory"))
                    .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            }
            else
            {
                optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Branch>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Products__19093A2B90762D5A");
                entity.Property(e => e.BranchName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
                entity.Property(e => e.CreateBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);
                entity.Property(e => e.CreateDate).HasColumnType("datetime");
                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);
                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
                entity.Property(e => e.Id)
               .IsRequired()
               .ValueGeneratedOnAdd();
                entity.Property(e => e.RowVersion)
                   .IsRequired()
                   .IsRowVersion()
                   .IsConcurrencyToken();
            });

            modelBuilder.Entity<CreditNote>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__CreditNo__AF360DA678C88E40");
                entity.Property(e => e.Id)
               .IsRequired()
               .ValueGeneratedOnAdd();
                entity.Property(e => e.RowVersion)
                   .IsRequired()
                   .IsRowVersion()
                   .IsConcurrencyToken();
                entity.Property(e => e.CreateBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);
                entity.Property(e => e.CreateDate).HasColumnType("datetime");
                entity.Property(e => e.CreditAmount).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.CreditDate).HasColumnType("datetime");
                entity.Property(e => e.OrderId).HasColumnName("OrderID");
                entity.Property(e => e.Reason).HasColumnType("text");
                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);
                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Order).WithMany(p => p.CreditNotes)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__CreditNot__Order__3C69FB99");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Customer__A4AE64B81A599153");

                entity.Property(e => e.Id)
               .IsRequired()
               .ValueGeneratedOnAdd();
                entity.Property(e => e.RowVersion)
                   .IsRequired()
                   .IsRowVersion()
                   .IsConcurrencyToken();
                entity.Property(e => e.Address).HasColumnType("text");
                entity.Property(e => e.ContactInfo)
                    .HasMaxLength(255)
                    .IsUnicode(false);
                entity.Property(e => e.CreateBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);
                entity.Property(e => e.CreateDate).HasColumnType("datetime");
                entity.Property(e => e.CustomerName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);
                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DebitNote>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__DebitNot__2B949F10F9566850");

                entity.Property(e => e.Id)
               .IsRequired()
               .ValueGeneratedOnAdd();
                entity.Property(e => e.RowVersion)
                   .IsRequired()
                   .IsRowVersion()
                   .IsConcurrencyToken();
                entity.Property(e => e.CreateBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);
                entity.Property(e => e.CreateDate).HasColumnType("datetime");
                entity.Property(e => e.DebitAmount).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.DebitDate).HasColumnType("datetime");
                entity.Property(e => e.OrderId).HasColumnName("OrderID");
                entity.Property(e => e.Reason).HasColumnType("text");
                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);
                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Order).WithMany(p => p.DebitNotes)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__DebitNote__Order__3F466844");
            });

            modelBuilder.Entity<DeliveryOrder>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Delivery__4CFAF410540FC42F");
                entity.Property(e => e.Id)
               .IsRequired()
               .ValueGeneratedOnAdd();
                entity.Property(e => e.RowVersion)
                   .IsRequired()
                   .IsRowVersion()
                   .IsConcurrencyToken();
                entity.Property(e => e.CreateBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);
                entity.Property(e => e.CreateDate).HasColumnType("datetime");
                entity.Property(e => e.OrderId).HasColumnName("OrderID");
                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");
                entity.Property(e => e.ShipmentStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);
                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Order).WithMany(p => p.DeliveryOrders)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__DeliveryO__Order__33D4B598");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Invoices__D796AAD5961368CB");
                entity.Property(e => e.Id)
               .IsRequired()
               .ValueGeneratedOnAdd();
                entity.Property(e => e.RowVersion)
                   .IsRequired()
                   .IsRowVersion()
                   .IsConcurrencyToken();
                entity.Property(e => e.CreateBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);
                entity.Property(e => e.CreateDate).HasColumnType("datetime");
                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
                entity.Property(e => e.OrderId).HasColumnName("OrderID");
                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);
                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Order).WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__Invoices__OrderI__36B12243");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Orders__C3905BAF809926F2");
                entity.Property(e => e.Id)
               .IsRequired()
               .ValueGeneratedOnAdd();
                entity.Property(e => e.RowVersion)
                   .IsRequired()
                   .IsRowVersion()
                   .IsConcurrencyToken();
                entity.Property(e => e.CreateBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);
                entity.Property(e => e.CreateDate).HasColumnType("datetime");
                entity.Property(e => e.OrderDate).HasColumnType("datetime");
                entity.Property(e => e.QuotationId).HasColumnName("QuotationID");
                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);
                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Quotation).WithMany(p => p.Orders)
                    .HasForeignKey(d => d.QuotationId)
                    .HasConstraintName("FK__Orders__Quotatio__2E1BDC42");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Products__B40CC6ED90DF025A");
                entity.Property(e => e.Id)
               .IsRequired()
               .ValueGeneratedOnAdd();
                entity.Property(e => e.RowVersion)
                   .IsRequired()
                   .IsRowVersion()
                   .IsConcurrencyToken();
                entity.Property(e => e.BranchId).HasColumnName("BranchID");
                entity.Property(e => e.CreateBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);
                entity.Property(e => e.CreateDate).HasColumnType("datetime");
                entity.Property(e => e.ProductDescription).HasColumnType("text");
                entity.Property(e => e.ProductName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);
                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Branch).WithMany(p => p.Products)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK__Products__Bran__267ABA7A");
            });

            modelBuilder.Entity<Quotation>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Quotatio__E19752B30C1048B1");
                entity.Property(e => e.Id)
               .IsRequired()
               .ValueGeneratedOnAdd();
                entity.Property(e => e.RowVersion)
                   .IsRequired()
                   .IsRowVersion()
                   .IsConcurrencyToken();
                entity.Property(e => e.CreateBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);
                entity.Property(e => e.CreateDate).HasColumnType("datetime");
                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
                entity.Property(e => e.QuotationDate).HasColumnType("datetime");
                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);
                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Customer).WithMany(p => p.Quotations)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Quotation__Custo__2B3F6F97");
            });

            modelBuilder.Entity<Receipt>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Receipts__CC08C4000ED11D62");
                entity.Property(e => e.Id)
               .IsRequired()
               .ValueGeneratedOnAdd();
                entity.Property(e => e.RowVersion)
                   .IsRequired()
                   .IsRowVersion()
                   .IsConcurrencyToken();
                entity.Property(e => e.AmountReceived).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.CreateBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);
                entity.Property(e => e.CreateDate).HasColumnType("datetime");
                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
                entity.Property(e => e.PaymentDate).HasColumnType("datetime");
                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);
                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Invoice).WithMany(p => p.Receipts)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("FK__Receipts__Invoic__398D8EEE");
            });

            modelBuilder.Entity<SalesOrder>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__SalesOrd__B14003C2E5E3E5DA");
                entity.Property(e => e.Id)
               .IsRequired()
               .ValueGeneratedOnAdd();
                entity.Property(e => e.RowVersion)
                   .IsRequired()
                   .IsRowVersion()
                   .IsConcurrencyToken();
                entity.Property(e => e.CreateBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);
                entity.Property(e => e.CreateDate).HasColumnType("datetime");
                entity.Property(e => e.OrderId).HasColumnName("OrderID");
                entity.Property(e => e.SalesOrderDate).HasColumnType("datetime");
                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);
                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Order).WithMany(p => p.SalesOrders)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__SalesOrde__Order__30F848ED");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
