using Microsoft.EntityFrameworkCore.Migrations;

namespace TRACNGHIEMONLINE.Migrations
{
    public partial class updatetableadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Scores_Students_StudentId_student",
                table: "Scores");

            migrationBuilder.DropForeignKey(
                name: "FK_Scores_Tests_TestId_test",
                table: "Scores");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Classes_ClassId_class",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_ClassId_class",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Scores_StudentId_student",
                table: "Scores");

            migrationBuilder.DropIndex(
                name: "IX_Scores_TestId_test",
                table: "Scores");

            migrationBuilder.DropColumn(
                name: "Time_to_do",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "Total_questions",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "ClassId_class",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "is_testing",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Detail",
                table: "Scores");

            migrationBuilder.DropColumn(
                name: "Id_student",
                table: "Scores");

            migrationBuilder.DropColumn(
                name: "StudentId_student",
                table: "Scores");

            migrationBuilder.DropColumn(
                name: "TestId_test",
                table: "Scores");

            migrationBuilder.AddColumn<int>(
                name: "ScoreId_score",
                table: "Tests",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeId",
                table: "Tests",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ClassStudent",
                columns: table => new
                {
                    ClassId_class = table.Column<int>(type: "int", nullable: false),
                    StudentsId_student = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassStudent", x => new { x.ClassId_class, x.StudentsId_student });
                    table.ForeignKey(
                        name: "FK_ClassStudent_Classes_ClassId_class",
                        column: x => x.ClassId_class,
                        principalTable: "Classes",
                        principalColumn: "Id_class",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassStudent_Students_StudentsId_student",
                        column: x => x.StudentsId_student,
                        principalTable: "Students",
                        principalColumn: "Id_student",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TypeExam",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Total_questions = table.Column<int>(type: "int", nullable: false),
                    Time_to_do = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeExam", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubjectTypeExam",
                columns: table => new
                {
                    SubjectsId_subject = table.Column<int>(type: "int", nullable: false),
                    TypeExamsId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                        name: "FK_SubjectTypeExam_TypeExam_TypeExamsId",
                        column: x => x.TypeExamsId,
                        principalTable: "TypeExam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tests_ScoreId_score",
                table: "Tests",
                column: "ScoreId_score");

            migrationBuilder.CreateIndex(
                name: "IX_Tests_TypeId",
                table: "Tests",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassStudent_StudentsId_student",
                table: "ClassStudent",
                column: "StudentsId_student");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectTypeExam_TypeExamsId",
                table: "SubjectTypeExam",
                column: "TypeExamsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Scores_ScoreId_score",
                table: "Tests",
                column: "ScoreId_score",
                principalTable: "Scores",
                principalColumn: "Id_score",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_TypeExam_TypeId",
                table: "Tests",
                column: "TypeId",
                principalTable: "TypeExam",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Scores_ScoreId_score",
                table: "Tests");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_TypeExam_TypeId",
                table: "Tests");

            migrationBuilder.DropTable(
                name: "ClassStudent");

            migrationBuilder.DropTable(
                name: "SubjectTypeExam");

            migrationBuilder.DropTable(
                name: "TypeExam");

            migrationBuilder.DropIndex(
                name: "IX_Tests_ScoreId_score",
                table: "Tests");

            migrationBuilder.DropIndex(
                name: "IX_Tests_TypeId",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "ScoreId_score",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Tests");

            migrationBuilder.AddColumn<int>(
                name: "Time_to_do",
                table: "Tests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Total_questions",
                table: "Tests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClassId_class",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "is_testing",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Detail",
                table: "Scores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id_student",
                table: "Scores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentId_student",
                table: "Scores",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TestId_test",
                table: "Scores",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassId_class",
                table: "Students",
                column: "ClassId_class");

            migrationBuilder.CreateIndex(
                name: "IX_Scores_StudentId_student",
                table: "Scores",
                column: "StudentId_student");

            migrationBuilder.CreateIndex(
                name: "IX_Scores_TestId_test",
                table: "Scores",
                column: "TestId_test");

            migrationBuilder.AddForeignKey(
                name: "FK_Scores_Students_StudentId_student",
                table: "Scores",
                column: "StudentId_student",
                principalTable: "Students",
                principalColumn: "Id_student",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Scores_Tests_TestId_test",
                table: "Scores",
                column: "TestId_test",
                principalTable: "Tests",
                principalColumn: "Id_test",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Classes_ClassId_class",
                table: "Students",
                column: "ClassId_class",
                principalTable: "Classes",
                principalColumn: "Id_class",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
