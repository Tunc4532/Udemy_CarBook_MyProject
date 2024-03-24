using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Udemy_CarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_rentACar_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentACars_Locations_LocationID",
                table: "RentACars");

            migrationBuilder.DropColumn(
                name: "PickUpLocationId",
                table: "RentACars");

            migrationBuilder.RenameColumn(
                name: "LocationID",
                table: "RentACars",
                newName: "LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_RentACars_LocationID",
                table: "RentACars",
                newName: "IX_RentACars_LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_RentACars_Locations_LocationId",
                table: "RentACars",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentACars_Locations_LocationId",
                table: "RentACars");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "RentACars",
                newName: "LocationID");

            migrationBuilder.RenameIndex(
                name: "IX_RentACars_LocationId",
                table: "RentACars",
                newName: "IX_RentACars_LocationID");

            migrationBuilder.AddColumn<int>(
                name: "PickUpLocationId",
                table: "RentACars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_RentACars_Locations_LocationID",
                table: "RentACars",
                column: "LocationID",
                principalTable: "Locations",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
