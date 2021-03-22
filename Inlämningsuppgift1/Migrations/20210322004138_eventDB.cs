using Microsoft.EntityFrameworkCore.Migrations;

namespace Inlämningsuppgift1.Migrations
{
    public partial class eventDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "organizer_id",
                table: "Event",
                newName: "organizerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "organizerID",
                table: "Event",
                newName: "organizer_id");
        }
    }
}
