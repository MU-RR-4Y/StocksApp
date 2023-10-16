using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StocksApp.Migrations
{
    /// <inheritdoc />
    public partial class renamedPSMTableToHolding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PortfolioStockModel_Portfolio_portfolioId",
                table: "PortfolioStockModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PortfolioStockModel",
                table: "PortfolioStockModel");

            migrationBuilder.RenameTable(
                name: "PortfolioStockModel",
                newName: "Holdings");

            migrationBuilder.RenameIndex(
                name: "IX_PortfolioStockModel_portfolioId",
                table: "Holdings",
                newName: "IX_Holdings_portfolioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Holdings",
                table: "Holdings",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Holdings_Portfolio_portfolioId",
                table: "Holdings",
                column: "portfolioId",
                principalTable: "Portfolio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Holdings_Portfolio_portfolioId",
                table: "Holdings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Holdings",
                table: "Holdings");

            migrationBuilder.RenameTable(
                name: "Holdings",
                newName: "PortfolioStockModel");

            migrationBuilder.RenameIndex(
                name: "IX_Holdings_portfolioId",
                table: "PortfolioStockModel",
                newName: "IX_PortfolioStockModel_portfolioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PortfolioStockModel",
                table: "PortfolioStockModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PortfolioStockModel_Portfolio_portfolioId",
                table: "PortfolioStockModel",
                column: "portfolioId",
                principalTable: "Portfolio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
