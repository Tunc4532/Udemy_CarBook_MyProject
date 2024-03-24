using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Udemy_CarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_reservation_car_relation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Reservatioons_CarId",
                table: "Reservatioons",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservatioons_Cars_CarId",
                table: "Reservatioons",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservatioons_Cars_CarId",
                table: "Reservatioons");

            migrationBuilder.DropIndex(
                name: "IX_Reservatioons_CarId",
                table: "Reservatioons");
        }
    }
}
