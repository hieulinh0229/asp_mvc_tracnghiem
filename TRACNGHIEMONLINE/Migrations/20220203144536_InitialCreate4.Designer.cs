﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TRACNGHIEMONLINE.DAL;

namespace TRACNGHIEMONLINE.Migrations
{
    [DbContext(typeof(TracNghiemDbContext))]
    [Migration("20220203144536_InitialCreate4")]
    partial class InitialCreate4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TRACNGHIEMONLINE.Models.Admin", b =>
                {
                    b.Property<int>("Id_admin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Last_login")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PermissionId_permission")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Timestamps")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_admin");

                    b.HasIndex("PermissionId_permission");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("TRACNGHIEMONLINE.Models.Class", b =>
                {
                    b.Property<int>("Id_class")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Class_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_class");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("TRACNGHIEMONLINE.Models.Permission", b =>
                {
                    b.Property<int>("Id_permission")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Permission_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_permission");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("TRACNGHIEMONLINE.Models.Question", b =>
                {
                    b.Property<int>("Id_question")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Answer_a")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Answer_b")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Answer_c")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Answer_d")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correct_answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img_content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SubjectId_subject")
                        .HasColumnType("int");

                    b.Property<string>("TestId_test")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("Timestamps")
                        .HasColumnType("datetime2");

                    b.Property<int>("Unit")
                        .HasColumnType("int");

                    b.HasKey("Id_question");

                    b.HasIndex("SubjectId_subject");

                    b.HasIndex("TestId_test");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("TRACNGHIEMONLINE.Models.Score", b =>
                {
                    b.Property<int>("Id_score")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_code")
                        .HasColumnType("int");

                    b.Property<int>("Id_student")
                        .HasColumnType("int");

                    b.Property<double>("Score_number")
                        .HasColumnType("float");

                    b.Property<int?>("StudentId_student")
                        .HasColumnType("int");

                    b.Property<string>("TestId_test")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("Time_finish")
                        .HasColumnType("datetime2");

                    b.HasKey("Id_score");

                    b.HasIndex("StudentId_student");

                    b.HasIndex("TestId_test");

                    b.ToTable("Scores");
                });

            modelBuilder.Entity("TRACNGHIEMONLINE.Models.Status", b =>
                {
                    b.Property<int>("Id_status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Status_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Timestamps")
                        .HasColumnType("datetime2");

                    b.HasKey("Id_status");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("TRACNGHIEMONLINE.Models.Student", b =>
                {
                    b.Property<int>("Id_student")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ClassId_class")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("is_testing")
                        .HasColumnType("int");

                    b.Property<DateTime?>("last_login")
                        .HasColumnType("datetime2");

                    b.Property<int?>("permissionId_permission")
                        .HasColumnType("int");

                    b.Property<string>("time_remaining")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("time_start")
                        .HasColumnType("datetime2");

                    b.HasKey("Id_student");

                    b.HasIndex("ClassId_class");

                    b.HasIndex("permissionId_permission");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("TRACNGHIEMONLINE.Models.Subject", b =>
                {
                    b.Property<int>("Id_subject")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Subject_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_subject");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("TRACNGHIEMONLINE.Models.Test", b =>
                {
                    b.Property<string>("Id_test")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StatusId_status")
                        .HasColumnType("int");

                    b.Property<int?>("StudentId_student")
                        .HasColumnType("int");

                    b.Property<int?>("SubjectId_subject")
                        .HasColumnType("int");

                    b.Property<string>("Test_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Time_to_do")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Timestamps")
                        .HasColumnType("datetime2");

                    b.Property<int>("Total_questions")
                        .HasColumnType("int");

                    b.HasKey("Id_test");

                    b.HasIndex("StatusId_status");

                    b.HasIndex("StudentId_student");

                    b.HasIndex("SubjectId_subject");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("TRACNGHIEMONLINE.Models.Admin", b =>
                {
                    b.HasOne("TRACNGHIEMONLINE.Models.Permission", "Permission")
                        .WithMany("Admins")
                        .HasForeignKey("PermissionId_permission");

                    b.Navigation("Permission");
                });

            modelBuilder.Entity("TRACNGHIEMONLINE.Models.Question", b =>
                {
                    b.HasOne("TRACNGHIEMONLINE.Models.Subject", "Subject")
                        .WithMany("Questions")
                        .HasForeignKey("SubjectId_subject");

                    b.HasOne("TRACNGHIEMONLINE.Models.Test", null)
                        .WithMany("Questions")
                        .HasForeignKey("TestId_test");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("TRACNGHIEMONLINE.Models.Score", b =>
                {
                    b.HasOne("TRACNGHIEMONLINE.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId_student");

                    b.HasOne("TRACNGHIEMONLINE.Models.Test", "Test")
                        .WithMany("Scores")
                        .HasForeignKey("TestId_test");

                    b.Navigation("Student");

                    b.Navigation("Test");
                });

            modelBuilder.Entity("TRACNGHIEMONLINE.Models.Student", b =>
                {
                    b.HasOne("TRACNGHIEMONLINE.Models.Class", "Class")
                        .WithMany("Students")
                        .HasForeignKey("ClassId_class");

                    b.HasOne("TRACNGHIEMONLINE.Models.Permission", "permission")
                        .WithMany("Students")
                        .HasForeignKey("permissionId_permission");

                    b.Navigation("Class");

                    b.Navigation("permission");
                });

            modelBuilder.Entity("TRACNGHIEMONLINE.Models.Test", b =>
                {
                    b.HasOne("TRACNGHIEMONLINE.Models.Status", "Status")
                        .WithMany("Tests")
                        .HasForeignKey("StatusId_status");

                    b.HasOne("TRACNGHIEMONLINE.Models.Student", null)
                        .WithMany("Tests")
                        .HasForeignKey("StudentId_student");

                    b.HasOne("TRACNGHIEMONLINE.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId_subject");

                    b.Navigation("Status");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("TRACNGHIEMONLINE.Models.Class", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("TRACNGHIEMONLINE.Models.Permission", b =>
                {
                    b.Navigation("Admins");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("TRACNGHIEMONLINE.Models.Status", b =>
                {
                    b.Navigation("Tests");
                });

            modelBuilder.Entity("TRACNGHIEMONLINE.Models.Student", b =>
                {
                    b.Navigation("Tests");
                });

            modelBuilder.Entity("TRACNGHIEMONLINE.Models.Subject", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("TRACNGHIEMONLINE.Models.Test", b =>
                {
                    b.Navigation("Questions");

                    b.Navigation("Scores");
                });
#pragma warning restore 612, 618
        }
    }
}
