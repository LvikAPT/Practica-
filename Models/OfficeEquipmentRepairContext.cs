using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace office_equipment_repair.Models;

public partial class OfficeEquipmentRepairContext : DbContext
{
    public OfficeEquipmentRepairContext()
    {
    }

    public OfficeEquipmentRepairContext(DbContextOptions<OfficeEquipmentRepairContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Diagnostic> Diagnostics { get; set; }

    public virtual DbSet<HistoryDiagnostic> HistoryDiagnostics { get; set; }

    public virtual DbSet<HistoryRepair> HistoryRepairs { get; set; }


    public virtual DbSet<Technic> Technics { get; set; }

    public virtual DbSet<TypesProblem> TypesProblems { get; set; }

    public virtual DbSet<TypesUser> TypesUsers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=office_equipment_repair;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Diagnostic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("diagnostics_pkey");

            entity.ToTable("diagnostics");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LastDiagnosticDate).HasColumnName("last_diagnostic_date");
            entity.Property(e => e.NextDiagnosticDate).HasColumnName("next_diagnostic_date");
            entity.Property(e => e.ProblemId).HasColumnName("problem_id");
            entity.Property(e => e.TechnicId).HasColumnName("technic_id");

            entity.HasOne(d => d.Problem).WithMany(p => p.Diagnostics)
                .HasForeignKey(d => d.ProblemId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fk_diagnostics_problem");

            entity.HasOne(d => d.Technic).WithMany(p => p.Diagnostics)
                .HasForeignKey(d => d.TechnicId)
                .HasConstraintName("fk_diagnostics_technic");
        });

        modelBuilder.Entity<HistoryDiagnostic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("history_diagnostic_pkey");

            entity.ToTable("history_diagnostic");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DiagnosticDate).HasColumnName("diagnostic_date");
            entity.Property(e => e.DiagnosticId).HasColumnName("diagnostic_id");

            entity.HasOne(d => d.Diagnostic).WithMany(p => p.HistoryDiagnostics)
                .HasForeignKey(d => d.DiagnosticId)
                .HasConstraintName("fk_history_diagnostic_diagnostics");
        });

        modelBuilder.Entity<HistoryRepair>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("history_repair_pkey");

            entity.ToTable("history_repair");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RepairDate).HasColumnName("repair_date");
            entity.Property(e => e.TechnicId).HasColumnName("technic_id");
            entity.Property(e => e.WorkDone).HasColumnName("work_done");
            // Removed WorkTypeId property mapping
            // entity.Property(e => e.WorkTypeId).HasColumnName("work_type_id");

            entity.HasOne(d => d.Technic).WithMany(p => p.HistoryRepairs)
                .HasForeignKey(d => d.TechnicId)
                .HasConstraintName("fk_history_repair_technic");

            // Removed WorkType relationship
            // entity.HasOne(d => d.WorkType).WithMany(p => p.HistoryRepairs)
            //     .HasForeignKey(d => d.WorkTypeId)
            //     .OnDelete(DeleteBehavior.SetNull)
            //     .HasConstraintName("fk_history_repair_work_type");
        });

        modelBuilder.Entity<Technic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("technic_pkey");

            entity.ToTable("technic");

            entity.HasIndex(e => e.SerialNumber, "technic_serial_number_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Model)
                .HasMaxLength(100)
                .HasColumnName("model");
            entity.Property(e => e.OrganizationId).HasColumnName("organization_id");
            entity.Property(e => e.ReceptionDate).HasColumnName("reception_date");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(100)
                .HasColumnName("serial_number");
        });

        modelBuilder.Entity<TypesProblem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("types_problem_pkey");

            entity.ToTable("types_problem");

            entity.HasIndex(e => e.ProblemType, "types_problem_problem_type_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ProblemType)
                .HasMaxLength(100)
                .HasColumnName("problem_type");
        });

        modelBuilder.Entity<TypesUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("types_user_pkey");

            entity.ToTable("types_user");

            entity.HasIndex(e => e.TypeName, "types_user_type_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.TypeName)
                .HasMaxLength(50)
                .HasColumnName("type_name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.HasIndex(e => e.Username, "users_username_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.TypeId).HasColumnName("type_id");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");

            entity.HasOne(d => d.Type).WithMany(p => p.Users)
                .HasForeignKey(d => d.TypeId)
                .HasConstraintName("users_type_id_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
