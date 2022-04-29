﻿// <auto-generated />
using System;
using DepartmentProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DepartmentExample.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220429123514_ilk")]
    partial class ilk
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DepartmentProject.Models.Department", b =>
                {
                    b.Property<int>("DepartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartId"), 1L, 1);

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartId = 1,
                            DepartmentName = "Muhasebe"
                        },
                        new
                        {
                            DepartId = 2,
                            DepartmentName = "Satın Alma"
                        },
                        new
                        {
                            DepartId = 3,
                            DepartmentName = "Müdür"
                        },
                        new
                        {
                            DepartId = 4,
                            DepartmentName = "Müdür Yardımcısı"
                        },
                        new
                        {
                            DepartId = 5,
                            DepartmentName = "Danışma"
                        },
                        new
                        {
                            DepartId = 6,
                            DepartmentName = "Sekreter"
                        });
                });

            modelBuilder.Entity("DepartmentProject.Models.Personel", b =>
                {
                    b.Property<int>("PersonelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonelId"), 1L, 1);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartId")
                        .HasColumnType("int");

                    b.Property<int?>("DepartmentDepartId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonelId");

                    b.HasIndex("DepartmentDepartId");

                    b.ToTable("Personels");

                    b.HasData(
                        new
                        {
                            PersonelId = 1,
                            City = "Trabzon",
                            DepartId = 3,
                            Name = "Mikdat",
                            Surname = "Gürses"
                        },
                        new
                        {
                            PersonelId = 2,
                            City = "Rize",
                            DepartId = 4,
                            Name = "Bilge",
                            Surname = "Yılmaz"
                        },
                        new
                        {
                            PersonelId = 3,
                            City = "Samsun",
                            DepartId = 1,
                            Name = "Yalçın",
                            Surname = "Uzun"
                        },
                        new
                        {
                            PersonelId = 4,
                            City = "Sivas",
                            DepartId = 2,
                            Name = "Dilara",
                            Surname = "İzibüyük"
                        },
                        new
                        {
                            PersonelId = 5,
                            City = "Sinop",
                            DepartId = 5,
                            Name = "Furkan",
                            Surname = "Elmas"
                        },
                        new
                        {
                            PersonelId = 6,
                            City = "Erzincan",
                            DepartId = 5,
                            Name = "Enes",
                            Surname = "Akpınar"
                        },
                        new
                        {
                            PersonelId = 7,
                            City = "Muş",
                            DepartId = 6,
                            Name = "Burak",
                            Surname = "Kapıcı"
                        });
                });

            modelBuilder.Entity("DepartmentProject.Models.Personel", b =>
                {
                    b.HasOne("DepartmentProject.Models.Department", "Department")
                        .WithMany("Personels")
                        .HasForeignKey("DepartmentDepartId");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("DepartmentProject.Models.Department", b =>
                {
                    b.Navigation("Personels");
                });
#pragma warning restore 612, 618
        }
    }
}
