using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StocksApp.Migrations
{
    /// <inheritdoc />
    public partial class updatedPortfolioStockModel_addCurrentPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "currentPrice",
                table: "PortfolioStockModel",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "PortfolioStockModel",
                keyColumn: "Id",
                keyValue: 1,
                column: "currentPrice",
                value: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "currentPrice",
                table: "PortfolioStockModel");
        }
    }
}
