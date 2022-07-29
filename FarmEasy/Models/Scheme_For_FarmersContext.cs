using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FarmEasy.Models
{
    public partial class Scheme_For_FarmersContext : DbContext
    {
        public Scheme_For_FarmersContext()
        {
        }

        public Scheme_For_FarmersContext(DbContextOptions<Scheme_For_FarmersContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Bidder> Bidders { get; set; }
        public virtual DbSet<Crop> Crops { get; set; }
        public virtual DbSet<Farmer> Farmers { get; set; }
        public virtual DbSet<Insurance> Insurances { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=.\\sqlexpress;database=Scheme_For_Farmers;trusted_connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("Admin");

                entity.Property(e => e.AdminId).HasColumnName("admin_id");

                entity.Property(e => e.ContactNum)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("contact_num")
                    .IsFixedLength(true);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Bidder>(entity =>
            {
                entity.ToTable("Bidder");

                entity.Property(e => e.BidderId).HasColumnName("bidder_id");

                entity.Property(e => e.Aadhaar).HasColumnName("aadhaar");

                entity.Property(e => e.AccNum).HasColumnName("acc_num");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Approved)
                    .HasColumnName("approved")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.ContactNum)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("contact_num")
                    .IsFixedLength(true);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Ifsc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("IFSC");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Pan)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("pan");

                entity.Property(e => e.Pincode).HasColumnName("pincode");

                entity.Property(e => e.Pswd)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("pswd");

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("state");

                entity.Property(e => e.TraderLicenceNum)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("trader_licence_num");
            });

            modelBuilder.Entity<Crop>(entity =>
            {
                entity.Property(e => e.CropId).HasColumnName("crop_id");

                entity.Property(e => e.BasePrice).HasColumnName("base_price");

                entity.Property(e => e.BidderId).HasColumnName("bidder_id");

                entity.Property(e => e.CropName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("crop_name")
                    .IsFixedLength(true);

                entity.Property(e => e.CropType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("crop_type");

                entity.Property(e => e.CurrentBid).HasColumnName("current_bid");

                entity.Property(e => e.FarmerId).HasColumnName("farmer_id");

                entity.Property(e => e.FertilizerType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("fertilizer_type");

                entity.Property(e => e.Qunatity).HasColumnName("qunatity");

                entity.Property(e => e.SellDate)
                    .HasColumnType("date")
                    .HasColumnName("sell_date");

                entity.Property(e => e.SoldPrice).HasColumnName("sold_price");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("('Unsold')");

                entity.HasOne(d => d.Bidder)
                    .WithMany(p => p.Crops)
                    .HasForeignKey(d => d.BidderId)
                    .HasConstraintName("FK__Crops__bidder_id__173876EA");

                entity.HasOne(d => d.Farmer)
                    .WithMany(p => p.Crops)
                    .HasForeignKey(d => d.FarmerId)
                    .HasConstraintName("FK__Crops__farmer_id__164452B1");
            });

            modelBuilder.Entity<Farmer>(entity =>
            {
                entity.ToTable("Farmer");

                entity.Property(e => e.FarmerId).HasColumnName("farmer_id");

                entity.Property(e => e.Aadhaar).HasColumnName("aadhaar");

                entity.Property(e => e.AccNum).HasColumnName("acc_num");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Approved)
                    .HasColumnName("approved")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.ContactNum)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("contact_num")
                    .IsFixedLength(true);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FarmLicenceNum)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("farm_licence_num");

                entity.Property(e => e.Ifsc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("IFSC");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Pan)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("pan");

                entity.Property(e => e.Pincode).HasColumnName("pincode");

                entity.Property(e => e.Pswd)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("pswd");

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Insurance>(entity =>
            {
                entity.ToTable("Insurance");

                entity.Property(e => e.InsuranceId).HasColumnName("insurance_id");

                entity.Property(e => e.AccNum).HasColumnName("acc_num");

                entity.Property(e => e.Approve)
                    .HasColumnName("approve")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Area)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Claim)
                    .HasColumnName("claim")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CropId).HasColumnName("crop_id");

                entity.Property(e => e.CropName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Crop_name");

                entity.Property(e => e.FarmerId).HasColumnName("farmer_id");

                entity.Property(e => e.Ifsc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("IFSC");

                entity.Property(e => e.InsuranceCompany)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Insurance_company")
                    .IsFixedLength(true);

                entity.Property(e => e.InsuranceNum)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("insurance_num");

                entity.Property(e => e.SharePremimum).HasColumnName("Share_premimum");

                entity.Property(e => e.SumInsurred).HasColumnName("Sum_insurred");

                entity.HasOne(d => d.Crop)
                    .WithMany(p => p.Insurances)
                    .HasForeignKey(d => d.CropId)
                    .HasConstraintName("FK__Insurance__crop___1A14E395");

                entity.HasOne(d => d.Farmer)
                    .WithMany(p => p.Insurances)
                    .HasForeignKey(d => d.FarmerId)
                    .HasConstraintName("FK__Insurance__farme__1B0907CE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
