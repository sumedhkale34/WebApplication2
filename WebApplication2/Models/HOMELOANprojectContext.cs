using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication2.Models
{
    public partial class HOMELOANprojectContext : DbContext
    {
        public HOMELOANprojectContext()
        {
        }

        public HOMELOANprojectContext(DbContextOptions<HOMELOANprojectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminLogin> AdminLogin { get; set; }
        public virtual DbSet<LoanDetails> LoanDetails { get; set; }
        public virtual DbSet<LoanRequest> LoanRequest { get; set; }
        public virtual DbSet<UserDetails> UserDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LAPTOP-COFPJNIM\\SQLEXPRESS;Database=HOMELOANproject;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminLogin>(entity =>
            {
                entity.HasKey(e => e.EmailId)
                    .HasName("PK__AdminLog__7ED91AEFF5C91B24");

                entity.Property(e => e.EmailId)
                    .HasColumnName("EmailID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LoanDetails>(entity =>
            {
                entity.HasKey(e => e.LoanNumber)
                    .HasName("PK__LoanDeta__EEC26629A47B5D8D");

                entity.Property(e => e.LoanNumber).ValueGeneratedNever();

                entity.Property(e => e.BankAccountNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Emi)
                    .IsRequired()
                    .HasColumnName("EMI")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LoanAmount)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LoanDate).HasColumnType("date");

                entity.Property(e => e.MaxLoan)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.BankAccountNoNavigation)
                    .WithMany(p => p.LoanDetails)
                    .HasForeignKey(d => d.BankAccountNo)
                    .HasConstraintName("FK__LoanDetai__BankA__1920BF5C");

                entity.HasOne(d => d.Email)
                    .WithMany(p => p.LoanDetails)
                    .HasForeignKey(d => d.EmailId)
                    .HasConstraintName("FK__LoanDetai__Email__182C9B23");
            });

            modelBuilder.Entity<LoanRequest>(entity =>
            {
                entity.HasKey(e => e.BankAccountNo)
                    .HasName("PK__LoanRequ__4E5D936B3AA5E5AE");

                entity.Property(e => e.BankAccountNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmploymentType)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EstimatedAmount)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MonthlyIncome)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Propertycity)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Propertystate)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Propertystreet)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RequestDate).HasColumnType("date");

                entity.Property(e => e.RequestEmi)
                    .IsRequired()
                    .HasColumnName("RequestEMI")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Email)
                    .WithMany(p => p.LoanRequest)
                    .HasForeignKey(d => d.EmailId)
                    .HasConstraintName("FK__LoanReque__Email__145C0A3F");
            });

            modelBuilder.Entity<UserDetails>(entity =>
            {
                entity.HasKey(e => e.EmailId)
                    .HasName("PK__UserDeta__7ED91ACF2CCE8F93");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AadharNo)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nationality)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PanCardNo)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
