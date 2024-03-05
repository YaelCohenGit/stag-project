using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Dal.Models;

public partial class DBContext : DbContext
{
    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }
    public static DbSet<AptDetails> AptDetails { get; set; }

    public static DbSet<Owner> Owners { get; set; }

    public static DbSet<Tourist> Tourists { get; set; }

    public static DbSet<WantedApt> WantedApts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AptDetails>(entity =>
        {
            entity.HasKey(e => e.AptDetailsId).HasName("PK__AptDetai__ADC332CFB675253E");

            entity.Property(e => e.AptDetailsId).ValueGeneratedNever();
            entity.Property(e => e.AptStyle)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Beds)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.City)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Country)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.PricePerNight)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Street)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("street");
        });

        modelBuilder.Entity<Owner>(entity =>
        {
            entity.HasKey(e => e.OwnerId).HasName("PK__Owners__819385B8FB5C26B7");

            entity.Property(e => e.OwnerId)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Email)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Tel)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.AptDetails).WithMany(p => p.Owners)
                .HasForeignKey(d => d.AptDetailsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Owners__AptDetai__4F7CD00D");
        });

        modelBuilder.Entity<Tourist>(entity =>
        {
            entity.HasKey(e => e.TouristId).HasName("PK__tmp_ms_x__8C91DFD1EA2B04BC");

            entity.Property(e => e.TouristId).ValueGeneratedNever();
            entity.Property(e => e.Email)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Tel)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<WantedApt>(entity =>
        {
            entity.ToTable("WantedApt");

            entity.Property(e => e.WantedAptId).ValueGeneratedNever();
            entity.Property(e => e.TouristId).HasColumnName("touristId");
            entity.Property(e => e.WantedCountry)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.Tourist).WithMany(p => p.WantedApts)
                .HasForeignKey(d => d.TouristId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__WantedApt__touri__5441852A");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
