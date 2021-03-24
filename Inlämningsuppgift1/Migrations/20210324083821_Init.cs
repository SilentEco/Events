using Microsoft.EntityFrameworkCore.Migrations;

namespace Inlämningsuppgift1.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attendee",
                columns: table => new
                {
                    attendeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone_number = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendee", x => x.attendeeID);
                });

            migrationBuilder.CreateTable(
                name: "Organizer",
                columns: table => new
                {
                    organizerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone_number = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizer", x => x.organizerID);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    eventID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organizerID = table.Column<int>(type: "int", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    place = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date = table.Column<int>(type: "int", nullable: false),
                    spots_available = table.Column<int>(type: "int", nullable: false),
                    attendeeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.eventID);
                    table.ForeignKey(
                        name: "FK_Event_Attendee_attendeeID",
                        column: x => x.attendeeID,
                        principalTable: "Attendee",
                        principalColumn: "attendeeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Event_Organizer_organizerID",
                        column: x => x.organizerID,
                        principalTable: "Organizer",
                        principalColumn: "organizerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Event_attendeeID",
                table: "Event",
                column: "attendeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Event_organizerID",
                table: "Event",
                column: "organizerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "Attendee");

            migrationBuilder.DropTable(
                name: "Organizer");
        }
    }
}
