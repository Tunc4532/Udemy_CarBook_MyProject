using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Udemy_CarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_reservations_status : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Reservatioons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Reservatioons");
        }
    }
}
