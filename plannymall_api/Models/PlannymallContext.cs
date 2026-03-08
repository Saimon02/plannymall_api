using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace plannymall_api.Models;

public partial class PlannymallContext : DbContext
{
    public PlannymallContext()
    {
    }

    public PlannymallContext(DbContextOptions<PlannymallContext> options)
        : base(options)
    {
    }

    public virtual DbSet<PasswordResetToken> PasswordResetTokens { get; set; }

    public virtual DbSet<RefreshToken> RefreshTokens { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pk");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.FirstName).HasColumnName("first_name");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.IsBlocked)
                .HasDefaultValue(false)
                .HasColumnName("is_blocked");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValue(false)
                .HasColumnName("is_deleted");
            entity.Property(e => e.IsReported)
                .HasDefaultValue(false)
                .HasColumnName("is_reported");
            entity.Property(e => e.LastName).HasColumnName("last_name");
            entity.Property(e => e.PasswordHash).HasColumnName("password_hash");
            entity.Property(e => e.PasswordReset)
                .HasDefaultValue(false)
                .HasColumnName("password_reset");
            entity.Property(e => e.PasswordSale).HasColumnName("password_sale");
            entity.Property(e => e.PhoneNumberId).HasColumnName("phone_number_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            entity.Property(e => e.Uuid).HasColumnName("uuid");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
