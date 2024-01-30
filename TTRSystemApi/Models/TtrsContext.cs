using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TTRSystemApi.Models;

public partial class TtrsContext : DbContext
{
    public TtrsContext()
    {
    }

    public TtrsContext(DbContextOptions<TtrsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<Coach> Coaches { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Seat> Seats { get; set; }

    public virtual DbSet<Station> Stations { get; set; }

    public virtual DbSet<Train> Trains { get; set; }

    public virtual DbSet<TrainStation> TrainStations { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:TtrsDbConnectionString");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Booking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__bookings__3213E83FFD093F02");

            entity.ToTable("bookings");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BookingDate).HasColumnName("bookingDate");
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("paymentStatus");
            entity.Property(e => e.SeatId).HasColumnName("seatId");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.Seat).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.SeatId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__bookings__seatId__75A278F5");

            entity.HasOne(d => d.User).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__bookings__userId__74AE54BC");
        });

        modelBuilder.Entity<Class>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__classes__3213E83F2986DE21");

            entity.ToTable("classes");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Coach>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__coaches__3213E83F06101493");

            entity.ToTable("coaches");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ClassId).HasColumnName("classId");
            entity.Property(e => e.Name)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("name");

            entity.HasOne(d => d.Class).WithMany(p => p.Coaches)
                .HasForeignKey(d => d.ClassId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__coaches__classId__619B8048");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__payments__3213E83FEB41E98E");

            entity.ToTable("payments");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.BookingId).HasColumnName("bookingId");
            entity.Property(e => e.PaymentDate).HasColumnName("paymentDate");
            entity.Property(e => e.TransactionId).HasColumnName("transactionId");

            entity.HasOne(d => d.Booking).WithMany(p => p.Payments)
                .HasForeignKey(d => d.BookingId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__payments__bookin__787EE5A0");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__roles__3213E83FA33D1336");

            entity.ToTable("roles");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Seat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__seats__3213E83F99C60BDF");

            entity.ToTable("seats");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Availability).HasColumnName("availability");
            entity.Property(e => e.CoachId).HasColumnName("coachId");
            entity.Property(e => e.Number).HasColumnName("number");
            entity.Property(e => e.TrainId).HasColumnName("trainId");

            entity.HasOne(d => d.Coach).WithMany(p => p.Seats)
                .HasForeignKey(d => d.CoachId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__seats__coachId__6477ECF3");

            entity.HasOne(d => d.Train).WithMany(p => p.Seats)
                .HasForeignKey(d => d.TrainId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__seats__trainId__656C112C");
        });

        modelBuilder.Entity<Station>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__stations__3213E83F99CF5430");

            entity.ToTable("stations");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.City)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.State)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("state");
        });

        modelBuilder.Entity<Train>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__trains__3213E83FD5BCF805");

            entity.ToTable("trains");

            entity.HasIndex(e => e.Number, "UQ__trains__FD291E4188528B48").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.DestinationStation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("destinationStation");
            entity.Property(e => e.Name)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Number).HasColumnName("number");
            entity.Property(e => e.SourceStation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sourceStation");
        });

        modelBuilder.Entity<TrainStation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__trainSta__3213E83F6B2C74D9");

            entity.ToTable("trainStation");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ArriveAt).HasColumnName("arriveAt");
            entity.Property(e => e.DepartAt).HasColumnName("departAt");
            entity.Property(e => e.StationId).HasColumnName("stationId");
            entity.Property(e => e.StopNumber).HasColumnName("stopNumber");
            entity.Property(e => e.TrainId).HasColumnName("trainId");

            entity.HasOne(d => d.Station).WithMany(p => p.TrainStations)
                .HasForeignKey(d => d.StationId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__trainStat__stati__693CA210");

            entity.HasOne(d => d.Train).WithMany(p => p.TrainStations)
                .HasForeignKey(d => d.TrainId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__trainStat__train__68487DD7");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__users__3213E83F19B6EA93");

            entity.ToTable("users");

            entity.HasIndex(e => e.Username, "UQ__users__F3DBC572E71812A9").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.DateOfBirth)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("dateOfBirth");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("firstName");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("gender");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lastName");
            entity.Property(e => e.Mobile)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("mobile");
            entity.Property(e => e.Password)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.RoleId).HasColumnName("roleId");
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("username");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__users__roleId__4D94879B");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
