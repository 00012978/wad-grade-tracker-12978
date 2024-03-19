using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GradeTracker12978.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTitleMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Assignments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Assignments");
        }
    }
}
