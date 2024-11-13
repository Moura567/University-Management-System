﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WinFormsApp1;

namespace WinFormsApp1.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("WinFormsApp1.Course", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("departmentid")
                        .HasColumnType("int");

                    b.Property<int>("hour")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("departmentid");

                    b.ToTable("courses");
                });

            modelBuilder.Entity("WinFormsApp1.CourseStudent", b =>
                {
                    b.Property<int>("studentid")
                        .HasColumnType("int");

                    b.Property<int>("courseid")
                        .HasColumnType("int");

                    b.HasKey("studentid", "courseid");

                    b.HasIndex("courseid");

                    b.ToTable("CourseStudents");
                });

            modelBuilder.Entity("WinFormsApp1.Department", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("capacity")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("departments");
                });

            modelBuilder.Entity("WinFormsApp1.Student", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("BirthDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2024, 11, 11, 22, 21, 2, 943, DateTimeKind.Local).AddTicks(8359));

                    b.Property<string>("NID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("departmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(8);

                    b.Property<string>("dept")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("General")
                        .HasColumnName("Department");

                    b.Property<double>("gpa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(0.0);

                    b.Property<int>("hours")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(18);

                    b.Property<int>("level")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("departmentId");

                    b.ToTable("students");
                });

            modelBuilder.Entity("WinFormsApp1.staff", b =>
                {
                    b.Property<string>("username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("12345678");

                    b.HasKey("username");

                    b.ToTable("staff");
                });

            modelBuilder.Entity("WinFormsApp1.Course", b =>
                {
                    b.HasOne("WinFormsApp1.Department", "Department")
                        .WithMany("courses")
                        .HasForeignKey("departmentid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("WinFormsApp1.CourseStudent", b =>
                {
                    b.HasOne("WinFormsApp1.Course", "Course")
                        .WithMany("CourseStudent")
                        .HasForeignKey("courseid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WinFormsApp1.Student", "Student")
                        .WithMany("CourseStudent")
                        .HasForeignKey("studentid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("WinFormsApp1.Student", b =>
                {
                    b.HasOne("WinFormsApp1.Department", "department")
                        .WithMany("students")
                        .HasForeignKey("departmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("department");
                });

            modelBuilder.Entity("WinFormsApp1.Course", b =>
                {
                    b.Navigation("CourseStudent");
                });

            modelBuilder.Entity("WinFormsApp1.Department", b =>
                {
                    b.Navigation("courses");

                    b.Navigation("students");
                });

            modelBuilder.Entity("WinFormsApp1.Student", b =>
                {
                    b.Navigation("CourseStudent");
                });
#pragma warning restore 612, 618
        }
    }
}