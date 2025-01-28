using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesLogin.Migrations
{
    /// <inheritdoc />
    public partial class AddNewColumnsToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Question1",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Answer1",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Question2",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Answer2",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Question3",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Answer3",
                table: "User",
                nullable: true);

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Question1",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Answer1",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Question2",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Answer2",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Question3",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Answer3",
                table: "User");
        }
    }
}
