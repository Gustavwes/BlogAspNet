using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BlogAspNet.Models
{
    public partial class BlogAspNetContext : DbContext
    {
        public virtual DbSet<Inlägg> Inlägg { get; set; }
        public virtual DbSet<Kategori> Kategori { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=localhost; Database=BlogAspNet ;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inlägg>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Inlägg1)
                    .HasColumnName("Inlägg")
                    .HasMaxLength(2000);

                entity.Property(e => e.Rubrik).HasMaxLength(50);
            });

            modelBuilder.Entity<Kategori>(entity =>
            {
                entity.Property(e => e.Namn).HasMaxLength(30);
            });
        }
    }
}
