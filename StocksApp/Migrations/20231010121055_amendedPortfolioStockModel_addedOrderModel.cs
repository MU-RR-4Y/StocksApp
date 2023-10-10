using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StocksApp.Migrations
{
    /// <inheritdoc />
    public partial class amendedPortfolioStockModel_addedOrderModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Change",
                table: "PortfolioStockModel");

            migrationBuilder.DropColumn(
                name: "direction",
                table: "PortfolioStockModel");

            migrationBuilder.DropColumn(
                name: "exchange",
                table: "PortfolioStockModel");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "PortfolioStockModel",
                newName: "currentValue");

            migrationBuilder.RenameColumn(
                name: "PreviousClose",
                table: "PortfolioStockModel",
                newName: "currentPerformance");

            migrationBuilder.RenameColumn(
                name: "Open",
                table: "PortfolioStockModel",
                newName: "bookValue");

            migrationBuilder.RenameColumn(
                name: "ChangePercent",
                table: "PortfolioStockModel",
                newName: "averagePrice");

            migrationBuilder.AddColumn<int>(
                name: "numberofShares",
                table: "PortfolioStockModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "currentValue",
                table: "Portfolio",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "currentPerformance",
                table: "Portfolio",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "cash",
                table: "Portfolio",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "bookValue",
                table: "Portfolio",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "numberofShares",
                table: "PortfolioStockModel");

            migrationBuilder.RenameColumn(
                name: "currentValue",
                table: "PortfolioStockModel",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "currentPerformance",
                table: "PortfolioStockModel",
                newName: "PreviousClose");

            migrationBuilder.RenameColumn(
                name: "bookValue",
                table: "PortfolioStockModel",
                newName: "Open");

            migrationBuilder.RenameColumn(
                name: "averagePrice",
                table: "PortfolioStockModel",
                newName: "ChangePercent");

            migrationBuilder.AddColumn<double>(
                name: "Change",
                table: "PortfolioStockModel",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "direction",
                table: "PortfolioStockModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "exchange",
                table: "PortfolioStockModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<double>(
                name: "currentValue",
                table: "Portfolio",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "currentPerformance",
                table: "Portfolio",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "cash",
                table: "Portfolio",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "bookValue",
                table: "Portfolio",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
