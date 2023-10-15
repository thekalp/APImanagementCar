using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Context.Models;

public partial class TestContext : DbContext
{
    public TestContext()
    {
    }

    public TestContext(DbContextOptions<TestContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblCarManagement> TblCarManagements { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=localhost;Database=Test;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblCarManagement>(entity =>
        {
            entity.ToTable("tblCarManagement");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Dom).HasColumnName("DOM");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
