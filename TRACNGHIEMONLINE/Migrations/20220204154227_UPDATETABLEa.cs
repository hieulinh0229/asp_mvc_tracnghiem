using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TRACNGHIEMONLINE.Migrations
{
    public partial class UPDATETABLEa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Avatar",
                table: "Students",
                newName: "AvatarUrl");

            migrationBuilder.RenameColumn(
                name: "Avatar",
                table: "Admins",
                newName: "AvatarUrl");

            migrationBuilder.AddColumn<byte[]>(
                name: "AvatarImage",
                table: "Students",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "AvatarImage",
                table: "Admins",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvatarImage",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "AvatarImage",
                table: "Admins");

            migrationBuilder.RenameColumn(
                name: "AvatarUrl",
                table: "Students",
                newName: "Avatar");

            migrationBuilder.RenameColumn(
                name: "AvatarUrl",
                table: "Admins",
                newName: "Avatar");
        }
    }
}
