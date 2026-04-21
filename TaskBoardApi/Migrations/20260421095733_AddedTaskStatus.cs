using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskBoardApi.Migrations
{
    /// <inheritdoc />
    public partial class AddedTaskStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsComplered",
                table: "Tasks",
                newName: "IsCompleted");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsCompleted",
                table: "Tasks",
                newName: "IsComplered");
        }
    }
}
