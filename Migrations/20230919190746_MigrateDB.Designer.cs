﻿// <auto-generated />
using Dynamic_User_Defined_Dashboards.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dynamic_User_Defined_Dashboards.Migrations
{
    [DbContext(typeof(Dashboard_TutorialContext))]
    [Migration("20230919190746_MigrateDB")]
    partial class MigrateDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("Dynamic_User_Defined_Dashboards.Models.DashboardLinkedElements", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DashboardId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ElementId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Placement")
                        .IsRequired()
                        .HasMaxLength(55)
                        .IsUnicode(false)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DashboardLinkedElements", "Dashboard_Tutorial");
                });

            modelBuilder.Entity("Dynamic_User_Defined_Dashboards.Models.DashboardsInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("TEXT");

                    b.Property<int>("TemplateId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Dashboards_Info", "Dashboard_Tutorial");
                });

            modelBuilder.Entity("Dynamic_User_Defined_Dashboards.Models.Elements", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Elements", "Dashboard_Tutorial");
                });

            modelBuilder.Entity("Dynamic_User_Defined_Dashboards.Models.Templates", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ElementsCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Templates", "Dashboard_Tutorial");
                });
#pragma warning restore 612, 618
        }
    }
}
