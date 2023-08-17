﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PracticalTwentyFour.Data.Contexts;

#nullable disable

namespace PracticalTwentyFour.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230811135019_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PracticalTwentyTwo.Domain.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "HR"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 3,
                            Name = "IT"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Sales"
                        },
                        new
                        {
                            Id = 5,
                            Name = "On-site"
                        });
                });

            modelBuilder.Entity("PracticalTwentyTwo.Domain.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(260)
                        .HasColumnType("nvarchar(260)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("JoiningDate")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartmentId = 1,
                            EmailAddress = "Noopur@gmail.com",
                            IsDeleted = false,
                            JoiningDate = new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Noopur Bhavsar",
                            Salary = 40000m
                        },
                        new
                        {
                            Id = 2,
                            DepartmentId = 2,
                            EmailAddress = "shivam@gmail.com",
                            IsDeleted = false,
                            JoiningDate = new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Shivam Patel",
                            Salary = 50000m
                        },
                        new
                        {
                            Id = 3,
                            DepartmentId = 3,
                            EmailAddress = "bhavin@gmail.com",
                            IsDeleted = false,
                            JoiningDate = new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Bhavin Kareliya",
                            Salary = 60000m
                        },
                        new
                        {
                            Id = 4,
                            DepartmentId = 3,
                            EmailAddress = "jil@gmail.com",
                            IsDeleted = false,
                            JoiningDate = new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Jil Patel",
                            Salary = 60000m
                        },
                        new
                        {
                            Id = 5,
                            DepartmentId = 4,
                            EmailAddress = "sales@gmail.com",
                            IsDeleted = false,
                            JoiningDate = new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Sales Manager",
                            Salary = 30000m
                        },
                        new
                        {
                            Id = 6,
                            DepartmentId = 5,
                            EmailAddress = "on-site@gmail.com",
                            IsDeleted = false,
                            JoiningDate = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "On-site Developer",
                            Salary = 35000m
                        });
                });

            modelBuilder.Entity("PracticalTwentyTwo.Domain.Entities.Employee", b =>
                {
                    b.HasOne("PracticalTwentyTwo.Domain.Entities.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("PracticalTwentyTwo.Domain.Entities.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
