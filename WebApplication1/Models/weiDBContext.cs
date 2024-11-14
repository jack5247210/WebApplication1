﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

public partial class weiDBContext : DbContext
{
    public weiDBContext()
    {
    }

    public weiDBContext(DbContextOptions<weiDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<MemberToday> MemberTodays { get; set; }

    public virtual DbSet<Table1> Table1s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=weiDB;User ID=sa;Password=sa");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MemberToday>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PK__MemberTo__15B69B8E53685DC9");

            entity.ToTable("MemberToday");

            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("GUID");
            entity.Property(e => e.ClassName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MemberName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Table1>(entity =>
        {
            entity.HasKey(e => e.Guid);

            entity.ToTable("Table_1");

            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .HasColumnName("GUID");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Ip)
                .HasMaxLength(32)
                .HasColumnName("IP");
            entity.Property(e => e.Name).HasMaxLength(20);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}