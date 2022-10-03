using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CustomerManagement.Models
{
    public partial class Nagaraj_DBContext : DbContext
    {
        public Nagaraj_DBContext()
        {
        }

        public Nagaraj_DBContext(DbContextOptions<Nagaraj_DBContext> options)
            : base(options)
        {
        }

   
        public virtual DbSet<Customer> Customer { get; set; }
   
        public virtual DbSet<CustomerTable> CustomerTable { get; set; }
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=W-H44PY03-0;Initial Catalog=Nagaraj_DB;Persist Security Info=True;User ID=SA;Password=admin");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustId)
                    .HasName("PK__customer__049E3A8965C9E8EC");

                entity.ToTable("customer");

                entity.Property(e => e.CustId)
                    .HasColumnName("CustID")
                    .ValueGeneratedNever();

                //entity.Property(e => e.BillAmount).HasColumnType("money");

                //entity.Property(e => e.BillDate)
                //    .HasColumnType("date")
                //    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustAddress)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

          
            modelBuilder.Entity<CustomerTable>(entity =>
            {
                entity.HasKey(e => e.CustId);
            });

          OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
