using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TRACNGHIEMONLINE.Migrations
{
    public partial class migrateFist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id_class = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Class_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id_class);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id_permission = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Permission_name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id_permission);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id_subject = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id_subject);
                });

            migrationBuilder.CreateTable(
                name: "TypeExams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Total_questions = table.Column<int>(type: "int", nullable: false),
                    Time_to_do = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeExams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id_admin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Last_login = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Timestamps = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PermissionId_permission = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id_admin);
                    table.ForeignKey(
                        name: "FK_Admins_Permissions_PermissionId_permission",
                        column: x => x.PermissionId_permission,
                        principalTable: "Permissions",
                        principalColumn: "Id_permission",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id_student = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    time_start = table.Column<DateTime>(type: "datetime2", nullable: true),
                    time_remaining = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    last_login = table.Column<DateTime>(type: "datetime2", nullable: true),
                    permissionId_permission = table.Column<int>(type: "int", nullable: true),
                    ClassId_class = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id_student);
                    table.ForeignKey(
                        name: "FK_Students_Classes_ClassId_class",
                        column: x => x.ClassId_class,
                        principalTable: "Classes",
                        principalColumn: "Id_class",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_Permissions_permissionId_permission",
                        column: x => x.permissionId_permission,
                        principalTable: "Permissions",
                        principalColumn: "Id_permission",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClassSubject",
                columns: table => new
                {
                    ClassesId_class = table.Column<int>(type: "int", nullable: false),
                    SubjectsId_subject = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassSubject", x => new { x.ClassesId_class, x.SubjectsId_subject });
                    table.ForeignKey(
                        name: "FK_ClassSubject_Classes_ClassesId_class",
                        column: x => x.ClassesId_class,
                        principalTable: "Classes",
                        principalColumn: "Id_class",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassSubject_Subjects_SubjectsId_subject",
                        column: x => x.SubjectsId_subject,
                        principalTable: "Subjects",
                        principalColumn: "Id_subject",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id_question = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Img_content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answer_a = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answer_b = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answer_c = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answer_d = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correct_answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubjectId_subject = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id_question);
                    table.ForeignKey(
                        name: "FK_Questions_Subjects_SubjectId_subject",
                        column: x => x.SubjectId_subject,
                        principalTable: "Subjects",
                        principalColumn: "Id_subject",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubjectTypeExam",
                columns: table => new
                {
                    SubjectsId_subject = table.Column<int>(type: "int", nullable: false),
                    TypeExamsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectTypeExam", x => new { x.SubjectsId_subject, x.TypeExamsId });
                    table.ForeignKey(
                        name: "FK_SubjectTypeExam_Subjects_SubjectsId_subject",
                        column: x => x.SubjectsId_subject,
                        principalTable: "Subjects",
                        principalColumn: "Id_subject",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubjectTypeExam_TypeExams_TypeExamsId",
                        column: x => x.TypeExamsId,
                        principalTable: "TypeExams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    Id_test = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Test_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Timestamps = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StudentId_student = table.Column<int>(type: "int", nullable: true),
                    Score = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: true),
                    SubjectId_subject = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.Id_test);
                    table.ForeignKey(
                        name: "FK_Tests_Students_StudentId_student",
                        column: x => x.StudentId_student,
                        principalTable: "Students",
                        principalColumn: "Id_student",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tests_Subjects_SubjectId_subject",
                        column: x => x.SubjectId_subject,
                        principalTable: "Subjects",
                        principalColumn: "Id_subject",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tests_TypeExams_TypeId",
                        column: x => x.TypeId,
                        principalTable: "TypeExams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuestionTest",
                columns: table => new
                {
                    QuestionsId_question = table.Column<int>(type: "int", nullable: false),
                    TestsId_test = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionTest", x => new { x.QuestionsId_question, x.TestsId_test });
                    table.ForeignKey(
                        name: "FK_QuestionTest_Questions_QuestionsId_question",
                        column: x => x.QuestionsId_question,
                        principalTable: "Questions",
                        principalColumn: "Id_question",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionTest_Tests_TestsId_test",
                        column: x => x.TestsId_test,
                        principalTable: "Tests",
                        principalColumn: "Id_test",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_PermissionId_permission",
                table: "Admins",
                column: "PermissionId_permission");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSubject_SubjectsId_subject",
                table: "ClassSubject",
                column: "SubjectsId_subject");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_SubjectId_subject",
                table: "Questions",
                column: "SubjectId_subject");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionTest_TestsId_test",
                table: "QuestionTest",
                column: "TestsId_test");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassId_class",
                table: "Students",
                column: "ClassId_class");

            migrationBuilder.CreateIndex(
                name: "IX_Students_permissionId_permission",
                table: "Students",
                column: "permissionId_permission");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectTypeExam_TypeExamsId",
                table: "SubjectTypeExam",
                column: "TypeExamsId");

            migrationBuilder.CreateIndex(
                name: "IX_Tests_StudentId_student",
                table: "Tests",
                column: "StudentId_student");

            migrationBuilder.CreateIndex(
                name: "IX_Tests_SubjectId_subject",
                table: "Tests",
                column: "SubjectId_subject");

            migrationBuilder.CreateIndex(
                name: "IX_Tests_TypeId",
                table: "Tests",
                column: "TypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "ClassSubject");

            migrationBuilder.DropTable(
                name: "QuestionTest");

            migrationBuilder.DropTable(
                name: "SubjectTypeExam");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "TypeExams");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Permissions");
        }
    }
}
