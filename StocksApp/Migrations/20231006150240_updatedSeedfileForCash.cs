using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StocksApp.Migrations
{
    /// <inheritdoc />
    public partial class updatedSeedfileForCash : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Portfolio",
                keyColumn: "Id",
                keyValue: 1,
                column: "cash",
                value: 50000.0);

            migrationBuilder.UpdateData(
                table: "Portfolio",
                keyColumn: "Id",
                keyValue: 2,
                column: "cash",
                value: 76000.0);

            migrationBuilder.UpdateData(
                table: "Portfolio",
                keyColumn: "Id",
                keyValue: 3,
                column: "cash",
                value: 25000.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Portfolio",
                keyColumn: "Id",
                keyValue: 1,
                column: "cash",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Portfolio",
                keyColumn: "Id",
                keyValue: 2,
                column: "cash",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Portfolio",
                keyColumn: "Id",
                keyValue: 3,
                column: "cash",
                value: 0.0);
        }
    }
}
