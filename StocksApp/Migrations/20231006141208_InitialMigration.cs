using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StocksApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Portfolio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bookValue = table.Column<double>(type: "float", nullable: true),
                    currentValue = table.Column<double>(type: "float", nullable: true),
                    currentPerformance = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PortfolioStockModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    shortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    exchange = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreviousClose = table.Column<double>(type: "float", nullable: false),
                    Open = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Change = table.Column<double>(type: "float", nullable: false),
                    ChangePercent = table.Column<double>(type: "float", nullable: false),
                    PortfolioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortfolioStockModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PortfolioStockModel_Portfolio_PortfolioId",
                        column: x => x.PortfolioId,
                        principalTable: "Portfolio",
                        principalColumn: "Id");
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
                table: "Portfolio",
                columns: new[] { "Id", "bookValue", "currentPerformance", "currentValue" },
                values: new object[,]
                {
                    { 1, 0.0, 0.0, 0.0 },
                    { 2, 0.0, 0.0, 0.0 },
                    { 3, 0.0, 0.0, 0.0 }
                });

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
                name: "IX_PortfolioStockModel_PortfolioId",
                table: "PortfolioStockModel",
                column: "PortfolioId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PortfolioId",
                table: "Users",
                column: "PortfolioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PortfolioStockModel");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Portfolio");
        }
    }
}
