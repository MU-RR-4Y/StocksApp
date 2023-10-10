using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StocksApp.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FxRates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GBPtoUSD = table.Column<double>(type: "float", nullable: false),
                    USDtoGBP = table.Column<double>(type: "float", nullable: false),
                    timestamp = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FxRates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Portfolio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bookValue = table.Column<double>(type: "float", nullable: false),
                    currentValue = table.Column<double>(type: "float", nullable: false),
                    currentPerformance = table.Column<double>(type: "float", nullable: false),
                    cash = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    regularMarketChange = table.Column<double>(type: "float", nullable: false),
                    regularMarketChangePercent = table.Column<double>(type: "float", nullable: false),
                    regularMarketTime = table.Column<int>(type: "int", nullable: false),
                    regularMarketPrice = table.Column<double>(type: "float", nullable: false),
                    regularMarketDayHigh = table.Column<double>(type: "float", nullable: false),
                    regularMarketDayLow = table.Column<double>(type: "float", nullable: false),
                    regularMarketPreviousClose = table.Column<double>(type: "float", nullable: false),
                    exchange = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    shortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    regularMarketOpen = table.Column<double>(type: "float", nullable: false),
                    symbol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    shortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numberOfShares = table.Column<int>(type: "int", nullable: false),
                    symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    fxRate = table.Column<double>(type: "float", nullable: false),
                    gbpCashValue = table.Column<double>(type: "float", nullable: false),
                    portfolioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Portfolio_portfolioId",
                        column: x => x.portfolioId,
                        principalTable: "Portfolio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PortfolioStockModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    portfolioId = table.Column<int>(type: "int", nullable: false),
                    shortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numberofShares = table.Column<int>(type: "int", nullable: false),
                    currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    averagePrice = table.Column<double>(type: "float", nullable: false),
                    bookValue = table.Column<double>(type: "float", nullable: false),
                    currentValue = table.Column<double>(type: "float", nullable: false),
                    currentPerformance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortfolioStockModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PortfolioStockModel_Portfolio_portfolioId",
                        column: x => x.portfolioId,
                        principalTable: "Portfolio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PortfolioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Portfolio_PortfolioId",
                        column: x => x.PortfolioId,
                        principalTable: "Portfolio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FxRates",
                columns: new[] { "Id", "GBPtoUSD", "USDtoGBP", "timestamp" },
                values: new object[] { 1, 1.0, 1.0, 1 });

            migrationBuilder.InsertData(
                table: "Portfolio",
                columns: new[] { "Id", "bookValue", "cash", "currentPerformance", "currentValue" },
                values: new object[,]
                {
                    { 1, 0.0, 50000.0, 0.0, 0.0 },
                    { 2, 0.0, 76000.0, 0.0, 0.0 },
                    { 3, 0.0, 25000.0, 0.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "currency", "exchange", "regularMarketChange", "regularMarketChangePercent", "regularMarketDayHigh", "regularMarketDayLow", "regularMarketOpen", "regularMarketPreviousClose", "regularMarketPrice", "regularMarketTime", "shortName", "symbol" },
                values: new object[,]
                {
                    { 1, "USD", "NYQ", -1.2199936, -1.3860414000000001, 0.0, 0.0, 88.0, 88.019999999999996, 86.799999999999997, 0, "3M Company", "MMM" },
                    { 2, "USD", "NMS", -7.3199769999999997, -1.4119781, 0.0, 0.0, 519.84000000000003, 518.41999999999996, 511.10000000000002, 0, "Adobe Inc.", "ADBE" },
                    { 3, "USD", "NMS", -2.4049988, -2.3109434000000002, 0.0, 0.0, 103.405, 104.06999999999999, 101.66500000000001, 0, "Advanced Micro Devices, Inc.", "AMD" },
                    { 4, "USD", "NMS", -0.94000243999999999, -0.69506239999999997, 0.0, 0.0, 135.06999999999999, 135.24000000000001, 134.30000000000001, 0, "Alphabet Inc.", "GOOGL" },
                    { 5, "USD", "NMS", -1.0180054000000001, -0.7470502, 0.0, 0.0, 136.13, 136.27000000000001, 135.25200000000001, 0, "Alphabet Inc.", "GOOG" },
                    { 6, "USD", "NMS", -2.3000029999999998, -1.811026, 0.0, 0.0, 126.70999999999999, 127.0, 124.7, 0, "Amazon.com, Inc.", "AMZN" },
                    { 7, "USD", "NYQ", -0.89480590000000004, -0.61275489999999999, 0.0, 0.0, 145.58000000000001, 146.03, 145.1352, 0, "American Express Company", "AXP" },
                    { 8, "USD", "NMS", -0.42999268000000002, -0.16199242, 0.0, 0.0, 266.19, 265.44, 265.00999999999999, 0, "Amgen Inc.", "AMGN" },
                    { 9, "USD", "NMS", -0.120010376, -0.069106520000000005, 0.0, 0.0, 173.78999999999999, 173.66, 173.53999999999999, 0, "Apple Inc", "AAPL" },
                    { 10, "USD", "NMS", -0.72999570000000003, -0.52404576999999997, 0.0, 0.0, 139.44999999999999, 139.30000000000001, 138.56999999999999, 0, "Applied Materials, Inc.", "AMAT" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "currency", "direction", "fxRate", "gbpCashValue", "numberOfShares", "portfolioId", "price", "shortName", "symbol" },
                values: new object[,]
                {
                    { 1, "USD", "buy", 0.80100000000000005, 282528.71999999997, 2000, 1, 176.36000000000001, "Apple Inc.", "AAPL" },
                    { 2, "USD", "buy", 0.80100000000000005, 42312.023999999998, 100, 2, 528.24000000000001, "Intuit Inc.", "INTU" },
                    { 3, "USD", "buy", 0.80100000000000005, 137216.106, 450, 3, 380.68000000000001, "Netflix, Inc.", "NFLX" },
                    { 4, "USD", "buy", 0.80100000000000005, 165733.30799999999, 1300, 2, 159.16, "Pepsico, Inc.", "PEP" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "PortfolioId" },
                values: new object[,]
                {
                    { 1, "Admin", "Test", 1 },
                    { 2, "Test", "User", 2 },
                    { 3, "User", "Admin", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_portfolioId",
                table: "Orders",
                column: "portfolioId");

            migrationBuilder.CreateIndex(
                name: "IX_PortfolioStockModel_portfolioId",
                table: "PortfolioStockModel",
                column: "portfolioId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PortfolioId",
                table: "Users",
                column: "PortfolioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FxRates");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "PortfolioStockModel");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Portfolio");
        }
    }
}
