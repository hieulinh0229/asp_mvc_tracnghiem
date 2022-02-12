using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TRACNGHIEMONLINE.Migrations
{
    public partial class updatetablesaaas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Timestamps",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "Questions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Timestamps",
                table: "Questions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Unit",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
