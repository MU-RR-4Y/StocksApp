using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StocksApp.Migrations
{
    /// <inheritdoc />
    public partial class updatedSeedsfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PortfolioStockModel",
                columns: new[] { "Id", "averagePrice", "bookValue", "currency", "currentPerformance", "currentValue", "numberofShares", "portfolioId", "shortName", "symbol" },
                values: new object[] { 1, 0.0, 0.0, "USD", 0.0, 0.0, 0, 1, "Apple Inc", "AAPL" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PortfolioStockModel",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
