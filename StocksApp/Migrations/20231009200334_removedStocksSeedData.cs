using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StocksApp.Migrations
{
    /// <inheritdoc />
    public partial class removedStocksSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PortfolioStockModel",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PortfolioStockModel",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PortfolioStockModel",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PortfolioStockModel",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PortfolioStockModel",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PortfolioStockModel",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PortfolioStockModel",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PortfolioStockModel",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PortfolioStockModel",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PortfolioStockModel",
                keyColumn: "Id",
                keyValue: 10);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PortfolioStockModel",
                columns: new[] { "Id", "Change", "ChangePercent", "Open", "PortfolioId", "PreviousClose", "Price", "currency", "exchange", "shortName", "symbol" },
                values: new object[,]
                {
                    { 1, -1.2199936, -1.3860414000000001, 88.0, null, 88.019999999999996, 86.799999999999997, "USD", "", "3M Company", "MMM" },
                    { 2, -7.3199769999999997, -1.4119781, 519.84000000000003, null, 518.41999999999996, 511.10000000000002, "USD", "", "Adobe Inc.", "ADBE" },
                    { 3, -2.4049988, -2.3109434000000002, 103.405, null, 104.06999999999999, 101.66500000000001, "USD", "", "Advanced Micro Devices, Inc.", "AMD" },
                    { 4, -0.94000243999999999, -0.69506239999999997, 135.06999999999999, null, 135.24000000000001, 134.30000000000001, "USD", "", "Alphabet Inc.", "GOOGL" },
                    { 5, -1.0180054000000001, -0.7470502, 136.13, null, 136.27000000000001, 135.25200000000001, "USD", "", "Alphabet Inc.", "GOOG" },
                    { 6, -2.3000029999999998, -1.811026, 126.70999999999999, null, 127.0, 124.7, "USD", "", "Amazon.com, Inc.", "AMZN" },
                    { 7, -0.89480590000000004, -0.61275489999999999, 145.58000000000001, null, 146.03, 145.1352, "USD", "", "American Express Company", "AXP" },
                    { 8, -0.42999268000000002, -0.16199242, 266.19, null, 265.44, 265.00999999999999, "USD", "", "Amgen Inc.", "AMGN" },
                    { 9, -0.120010376, -0.069106520000000005, 173.78999999999999, null, 173.66, 173.53999999999999, "USD", "", "Apple Inc", "AAPL" },
                    { 10, -0.72999570000000003, -0.52404576999999997, 139.44999999999999, null, 139.30000000000001, 138.56999999999999, "USD", "", "Applied Materials, Inc.", "AMAT" }
                });
        }
    }
}
