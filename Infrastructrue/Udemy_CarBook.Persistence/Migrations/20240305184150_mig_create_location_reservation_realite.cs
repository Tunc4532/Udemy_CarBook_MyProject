using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Udemy_CarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_create_location_reservation_realite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservatioons",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    PickUpLocationId = table.Column<int>(type: "int", nullable: true),
                    DropOffLocationId = table.Column<int>(type: "int", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DriverLicanseYear = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservatioons", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_Reservatioons_Locations_DropOffLocationId",
                        column: x => x.DropOffLocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationID");
                    table.ForeignKey(
                        name: "FK_Reservatioons_Locations_PickUpLocationId",
                        column: x => x.PickUpLocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservatioons_DropOffLocationId",
                table: "Reservatioons",
                column: "DropOffLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservatioons_PickUpLocationId",
                table: "Reservatioons",
                column: "PickUpLocationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservatioons");
        }
    }
}
