using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Frameworklab.Migrations
{
    /// <inheritdoc />
    public partial class UpdatingModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_students",
                table: "students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_books",
                table: "books");

            migrationBuilder.RenameTable(
                name: "students",
                newName: "Studeent");

            migrationBuilder.RenameTable(
                name: "books",
                newName: "Boooook");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Boooook",
                newName: "Bookprice");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Studeent",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Boooook",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Studeent",
                table: "Studeent",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Boooook",
                table: "Boooook",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Studeent",
                table: "Studeent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Boooook",
                table: "Boooook");

            migrationBuilder.RenameTable(
                name: "Studeent",
                newName: "students");

            migrationBuilder.RenameTable(
                name: "Boooook",
                newName: "books");

            migrationBuilder.RenameColumn(
                name: "Bookprice",
                table: "books",
                newName: "Price");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "books",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_students",
                table: "students",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_books",
                table: "books",
                column: "Id");
        }
    }
}
