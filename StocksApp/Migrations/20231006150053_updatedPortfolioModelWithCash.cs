using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StocksApp.Migrations
{
    /// <inheritdoc />
    public partial class updatedPortfolioModelWithCash : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "cash",
                table: "Portfolio",
                type: "float",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cash",
                table: "Portfolio");
        }
    }
}
