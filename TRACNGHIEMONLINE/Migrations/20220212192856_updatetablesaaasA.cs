using Microsoft.EntityFrameworkCore.Migrations;

namespace TRACNGHIEMONLINE.Migrations
{
    public partial class updatetablesaaasA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_ClassSubject_SubjectsId_subject",
                table: "ClassSubject",
                column: "SubjectsId_subject");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassSubject");
        }
    }
}
