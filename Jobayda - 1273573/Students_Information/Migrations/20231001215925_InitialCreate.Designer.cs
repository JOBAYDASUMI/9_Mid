﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Students_Information.Models;

#nullable disable

namespace Students_Information.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    [Migration("20231001215925_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Students_Information.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<DateTime?>("AdmissionDate")
                        .IsRequired()
                        .HasColumnType("date");

                    b.Property<decimal>("CourseFee")
                        .HasColumnType("money");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            AdmissionDate = new DateTime(2022, 5, 29, 3, 59, 25, 201, DateTimeKind.Local).AddTicks(6229),
                            CourseFee = 460m,
                            CourseName = "Course1",
                            StudentId = 1
                        },
                        new
                        {
                            CourseId = 2,
                            AdmissionDate = new DateTime(2022, 8, 23, 3, 59, 25, 201, DateTimeKind.Local).AddTicks(6288),
                            CourseFee = 894m,
                            CourseName = "Course2",
                            StudentId = 2
                        },
                        new
                        {
                            CourseId = 3,
                            AdmissionDate = new DateTime(2022, 6, 10, 3, 59, 25, 201, DateTimeKind.Local).AddTicks(6310),
                            CourseFee = 1293m,
                            CourseName = "Course3",
                            StudentId = 3
                        },
                        new
                        {
                            CourseId = 4,
                            AdmissionDate = new DateTime(2022, 8, 23, 3, 59, 25, 201, DateTimeKind.Local).AddTicks(6328),
                            CourseFee = 1900m,
                            CourseName = "Course4",
                            StudentId = 4
                        },
                        new
                        {
                            CourseId = 5,
                            AdmissionDate = new DateTime(2022, 8, 8, 3, 59, 25, 201, DateTimeKind.Local).AddTicks(6348),
                            CourseFee = 2160m,
                            CourseName = "Course5",
                            StudentId = 5
                        },
                        new
                        {
                            CourseId = 6,
                            AdmissionDate = new DateTime(2022, 7, 21, 3, 59, 25, 201, DateTimeKind.Local).AddTicks(6374),
                            CourseFee = 2670m,
                            CourseName = "Course6",
                            StudentId = 1
                        },
                        new
                        {
                            CourseId = 7,
                            AdmissionDate = new DateTime(2022, 7, 23, 3, 59, 25, 201, DateTimeKind.Local).AddTicks(6395),
                            CourseFee = 2842m,
                            CourseName = "Course7",
                            StudentId = 2
                        },
                        new
                        {
                            CourseId = 8,
                            AdmissionDate = new DateTime(2022, 7, 30, 3, 59, 25, 201, DateTimeKind.Local).AddTicks(6417),
                            CourseFee = 3600m,
                            CourseName = "Course8",
                            StudentId = 3
                        });
                });

            modelBuilder.Entity("Students_Information.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool?>("IsRegular")
                        .HasColumnType("bit");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            Age = 25,
                            Gender = 4,
                            Picture = "1jpg",
                            StudentName = "Student 1"
                        },
                        new
                        {
                            StudentId = 2,
                            Age = 11,
                            Gender = 4,
                            Picture = "2jpg",
                            StudentName = "Student 2"
                        },
                        new
                        {
                            StudentId = 3,
                            Age = 27,
                            Gender = 2,
                            Picture = "3jpg",
                            StudentName = "Student 3"
                        },
                        new
                        {
                            StudentId = 4,
                            Age = 11,
                            Gender = 4,
                            Picture = "4jpg",
                            StudentName = "Student 4"
                        },
                        new
                        {
                            StudentId = 5,
                            Age = 27,
                            Gender = 3,
                            Picture = "5jpg",
                            StudentName = "Student 5"
                        });
                });

            modelBuilder.Entity("Students_Information.Models.Course", b =>
                {
                    b.HasOne("Students_Information.Models.Student", "Student")
                        .WithMany("Courses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Students_Information.Models.Student", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
