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
    [Migration("20220212131445_updatetablesaaas")]
    partial class updatetablesaaas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ClassStudent", b =>
                {
                    b.Property<int>("ClassId_class")
                        .HasColumnType("int");

                    b.Property<int>("StudentsId_student")
                        .HasColumnType("int");

                    b.HasKey("ClassId_class", "StudentsId_student");

                    b.HasIndex("StudentsId_student");

                    b.ToTable("ClassStudent");
                });

            modelBuilder.Entity("QuestionTest", b =>
                {
                    b.Property<int>("QuestionsId_question")
                        .HasColumnType("int");

                    b.Property<string>("TestsId_test")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("QuestionsId_question", "TestsId_test");

                    b.HasIndex("TestsId_test");

                    b.ToTable("QuestionTest");
                });

            modelBuilder.Entity("SubjectTypeExam", b =>
                {
                    b.Property<int>("SubjectsId_subject")
                        .HasColumnType("int");

                    b.Property<int>("TypeExamsId")
                        .HasColumnType("int");

                    b.HasKey("SubjectsId_subject", "TypeExamsId");

                    b.HasIndex("TypeExamsId");

                    b.ToTable("SubjectTypeExam");
                });

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

                    b.Property<string>("Description")
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

                    b.HasKey("Id_question");

                    b.HasIndex("SubjectId_subject");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("TRACNGHIEMONLINE.Models.Score", b =>
                {
                    b.Property<int>("Id_score")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Id_code")
                        .HasColumnType("int");

                    b.Property<double>("Score_number")
                        .HasColumnType("float");

                    b.Property<DateTime?>("Time_finish")
                        .HasColumnType("datetime2");

                    b.HasKey("Id_score");

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

                    b.Property<DateTime?>("last_login")
                        .HasColumnType("datetime2");

                    b.Property<int?>("permissionId_permission")
                        .HasColumnType("int");

                    b.Property<string>("time_remaining")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("time_start")
                        .HasColumnType("datetime2");

                    b.HasKey("Id_student");

                    b.HasIndex("permissionId_permission");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("TRACNGHIEMONLINE.Models.Subject", b =>
                {
                    b.Property<int>("Id_subject")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<int?>("ScoreId_score")
                        .HasColumnType("int");

                    b.Property<int?>("StatusId_status")
                        .HasColumnType("int");

                    b.Property<int?>("StudentId_student")
                        .HasColumnType("int");

                    b.Property<int?>("SubjectId_subject")
                        .HasColumnType("int");

                    b.Property<string>("Test_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Timestamps")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id_test");

                    b.HasIndex("ScoreId_score");

                    b.HasIndex("StatusId_status");

                    b.HasIndex("StudentId_student");

                    b.HasIndex("SubjectId_subject");

                    b.HasIndex("TypeId");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("TRACNGHIEMONLINE.Models.TypeExam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Time_to_do")
                        .HasColumnType("int");

                    b.Property<int>("Total_questions")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TypeExams");
                });

            modelBuilder.Entity("ClassStudent", b =>
                {
                    b.HasOne("TRACNGHIEMONLINE.Models.Class", null)
                        .WithMany()
                        .HasForeignKey("ClassId_class")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TRACNGHIEMONLINE.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsId_student")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QuestionTest", b =>
                {
                    b.HasOne("TRACNGHIEMONLINE.Models.Question", null)
                        .WithMany()
                        .HasForeignKey("QuestionsId_question")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TRACNGHIEMONLINE.Models.Test", null)
                        .WithMany()
                        .HasForeignKey("TestsId_test")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SubjectTypeExam", b =>
                {
                    b.HasOne("TRACNGHIEMONLINE.Models.Subject", null)
                        .WithMany()
                        .HasForeignKey("SubjectsId_subject")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TRACNGHIEMONLINE.Models.TypeExam", null)
                        .WithMany()
                        .HasForeignKey("TypeExamsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("TRACNGHIEMONLINE.Models.Student", b =>
                {
                    b.HasOne("TRACNGHIEMONLINE.Models.Permission", "permission")
                        .WithMany("Students")
                        .HasForeignKey("permissionId_permission");

                    b.Navigation("permission");
                });

            modelBuilder.Entity("TRACNGHIEMONLINE.Models.Test", b =>
                {
                    b.HasOne("TRACNGHIEMONLINE.Models.Score", "Score")
                        .WithMany("Tests")
                        .HasForeignKey("ScoreId_score");

                    b.HasOne("TRACNGHIEMONLINE.Models.Status", "Status")
                        .WithMany("Tests")
                        .HasForeignKey("StatusId_status");

                    b.HasOne("TRACNGHIEMONLINE.Models.Student", "Student")
                        .WithMany("Tests")
                        .HasForeignKey("StudentId_student");

                    b.HasOne("TRACNGHIEMONLINE.Models.Subject", "Subject")
                        .WithMany("Tests")
                        .HasForeignKey("SubjectId_subject");

                    b.HasOne("TRACNGHIEMONLINE.Models.TypeExam", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");

                    b.Navigation("Score");

                    b.Navigation("Status");

                    b.Navigation("Student");

                    b.Navigation("Subject");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("TRACNGHIEMONLINE.Models.Permission", b =>
                {
                    b.Navigation("Admins");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("TRACNGHIEMONLINE.Models.Score", b =>
                {
                    b.Navigation("Tests");
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

                    b.Navigation("Tests");
                });
#pragma warning restore 612, 618
        }
    }
}
