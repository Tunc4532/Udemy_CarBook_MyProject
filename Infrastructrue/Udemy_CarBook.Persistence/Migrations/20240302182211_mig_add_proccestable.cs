using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Udemy_CarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_proccestable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Custemers",
                columns: table => new
                {
                    CustemerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustemerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustemerSurName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustemerMail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Custemers", x => x.CustemerId);
                });

            migrationBuilder.CreateTable(
                name: "RentACarProcces",
                columns: table => new
                {
                    RentACarProcceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarID = table.Column<int>(type: "int", nullable: false),
                    PickUpLocation = table.Column<int>(type: "int", nullable: false),
                    DropOffLocation = table.Column<int>(type: "int", nullable: false),
                    PickUpDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DropOffDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PickUpTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DropOffTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustemerId = table.Column<int>(type: "int", nullable: false),
                    PickUpDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DropOffDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentACarProcces", x => x.RentACarProcceId);
                    table.ForeignKey(
                        name: "FK_RentACarProcces_Cars_CarID",
                        column: x => x.CarID,
                        principalTable: "Cars",
                        principalColumn: "CarID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentACarProcces_Custemers_CustemerId",
                        column: x => x.CustemerId,
                        principalTable: "Custemers",
                        principalColumn: "CustemerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RentACarProcces_CarID",
                table: "RentACarProcces",
                column: "CarID");

            migrationBuilder.CreateIndex(
                name: "IX_RentACarProcces_CustemerId",
                table: "RentACarProcces",
                column: "CustemerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RentACarProcces");

            migrationBuilder.DropTable(
                name: "Custemers");
        }
    }
}
