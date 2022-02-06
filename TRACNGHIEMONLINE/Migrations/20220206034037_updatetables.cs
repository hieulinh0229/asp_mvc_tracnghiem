using Microsoft.EntityFrameworkCore.Migrations;

namespace TRACNGHIEMONLINE.Migrations
{
    public partial class updatetables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Tests_TestId_test",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_TestId_test",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "TestId_test",
                table: "Questions");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Subjects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: true);

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
                name: "IX_QuestionTest_TestsId_test",
                table: "QuestionTest",
                column: "TestsId_test");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionTest");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Classes");

            migrationBuilder.AddColumn<string>(
                name: "TestId_test",
                table: "Questions",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Questions_TestId_test",
                table: "Questions",
                column: "TestId_test");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Tests_TestId_test",
                table: "Questions",
                column: "TestId_test",
                principalTable: "Tests",
                principalColumn: "Id_test",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
