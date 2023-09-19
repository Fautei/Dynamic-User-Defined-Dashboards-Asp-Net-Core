using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Dynamic_User_Defined_Dashboards.Models
{
    public partial class Dashboard_TutorialContext : DbContext
    {
        public Dashboard_TutorialContext()
        {
        }

        public Dashboard_TutorialContext(DbContextOptions<Dashboard_TutorialContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DashboardLinkedElements> DashboardLinkedElements { get; set; }
        public virtual DbSet<DashboardsInfo> DashboardsInfo { get; set; }
        public virtual DbSet<Elements> Elements { get; set; }
        public virtual DbSet<Templates> Templates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlite("Data Source=db.sql");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<DashboardLinkedElements>(entity =>
            {
                entity.ToTable("DashboardLinkedElements", "Dashboard_Tutorial");

                entity.Property(e => e.Id);

                entity.Property(e => e.DashboardId);

                entity.Property(e => e.ElementId);

                entity.Property(e => e.Placement)
                    .IsRequired()
                    .HasMaxLength(55)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DashboardsInfo>(entity =>
            {
                entity.ToTable("Dashboards_Info", "Dashboard_Tutorial");

                entity.Property(e => e.Id);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateId);
            });

            modelBuilder.Entity<Elements>(entity =>
            {
                entity.ToTable("Elements", "Dashboard_Tutorial");

                entity.Property(e => e.Id);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Templates>(entity =>
            {
                entity.ToTable("Templates", "Dashboard_Tutorial");

                entity.Property(e => e.Id);

                entity.Property(e => e.ElementsCount);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });
        }
    }
}
