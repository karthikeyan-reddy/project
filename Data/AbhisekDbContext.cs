using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace propertyinsurance2.Data;

public partial class AbhisekDbContext : DbContext
{
    public AbhisekDbContext()
    {
    }

    public AbhisekDbContext(DbContextOptions<AbhisekDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Agent> Agents { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server = W-674PY03-1;Database = AbhisekDb; User ID = sa; Password = Password@12345; TrustServerCertificate =True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Agent>(entity =>
        {
            entity.ToTable("Agent");
        });

       

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customer");

            entity.Property(e => e.Password)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

       

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
