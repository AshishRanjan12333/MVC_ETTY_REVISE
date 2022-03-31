using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_ETTY_REVISE.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GetLocations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Place = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetLocations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GetCustomers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    C_Name = table.Column<string>(nullable: true),
                    C_Email = table.Column<string>(nullable: true),
                    C_Mobile = table.Column<string>(nullable: true),
                    C_Gender = table.Column<string>(nullable: true),
                    locationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetCustomers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GetCustomers_GetLocations_locationId",
                        column: x => x.locationId,
                        principalTable: "GetLocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GetCustomers_locationId",
                table: "GetCustomers",
                column: "locationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GetCustomers");

            migrationBuilder.DropTable(
                name: "GetLocations");
        }
    }
}
