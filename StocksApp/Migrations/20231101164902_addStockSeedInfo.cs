using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StocksApp.Migrations
{
    /// <inheritdoc />
    public partial class addStockSeedInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BookValueOrder",
                table: "InitialValueOrders",
                newName: "InitialValOrder");

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "currency", "exchange", "regularMarketChange", "regularMarketChangePercent", "regularMarketDayHigh", "regularMarketDayLow", "regularMarketOpen", "regularMarketPreviousClose", "regularMarketPrice", "regularMarketTime", "shortName", "symbol" },
                values: new object[,]
                {
                    { 1, "USD", "NYQ", 1.2600020999999999, 1.4208413, 90.135000000000005, 88.549999999999997, 88.920000000000002, 88.680000000000007, 89.939999999999998, 1697486447, "3M Company", "MMM" },
                    { 2, "USD", "NMS", 1.9799804999999999, 0.36080990000000002, 555.57000000000005, 545.69039999999995, 553.17999999999995, 548.75999999999999, 550.74000000000001, 1697486401, "Adobe Inc.", "ADBE" },
                    { 3, "USD", "NMS", 1.3700026999999999, 1.3036471999999999, 107.48, 105.03, 105.42, 105.09, 106.45999999999999, 1697486447, "Advanced Micro Devices, Inc.", "AMD" },
                    { 4, "USD", "NMS", 1.7350006, 1.2631047, 139.63, 137.99000000000001, 138.16999999999999, 137.36000000000001, 139.095, 1697486447, "Alphabet Inc.", "GOOGL" },
                    { 5, "USD", "NMS", 1.9100037000000001, 1.3782679, 140.905, 139.33000000000001, 139.72999999999999, 138.58000000000001, 140.49000000000001, 1697486447, "Alphabet Inc.", "GOOG" },
                    { 6, "USD", "NMS", 2.7600098000000002, 2.1265196999999998, 133.06999999999999, 130.42500000000001, 130.69, 129.78999999999999, 132.55000000000001, 1697486447, "Amazon.com, Inc.", "AMZN" },
                    { 7, "USD", "NYQ", 1.6899872, 1.1184561, 153.41, 151.20500000000001, 152.37, 151.09999999999999, 152.78999999999999, 1697486447, "American Express Company", "AXP" },
                    { 8, "USD", "NMS", 2.7799988, 0.97852826000000004, 287.81, 283.81, 284.5, 284.10000000000002, 286.88, 1697486447, "Amgen Inc.", "AMGN" },
                    { 9, "USD", "NMS", -0.13000487999999999, -0.072689340000000005, 179.07499999999999, 176.50999999999999, 176.75, 178.84999999999999, 178.72, 1697486447, "Apple Inc.", "AAPL" },
                    { 10, "USD", "NMS", -0.13999939, -0.099191860000000007, 142.56, 139.73519999999999, 141.75999999999999, 141.13999999999999, 141.0, 1697486447, "Applied Materials, Inc.", "AMAT" },
                    { 11, "USD", "NMS", 1.7599944999999999, 0.71110885999999995, 250.11000000000001, 247.66999999999999, 248.91, 247.5, 249.25999999999999, 1697486447, "Automatic Data Processing, Inc.", "ADP" },
                    { 12, "USD", "NYQ", 0.019989013999999999, 0.010810131000000001, 186.22999999999999, 182.5, 185.91, 184.91, 184.93000000000001, 1697486447, "Boeing Company (The)", "BA" },
                    { 13, "USD", "NMS", 16.389893000000001, 0.55557449999999997, 3000.1399999999999, 2961.165, 2973.6999999999998, 2950.0799999999999, 2966.4699999999998, 1697486447, "Booking Holdings Inc. Common Sty", "BKNG" },
                    { 14, "USD", "NMS", 19.390014999999899, 2.1954769999999999, 915.78499999999997, 890.97000000000003, 890.97000000000003, 883.17999999999995, 902.57000000000005, 1697486447, "Broadcom Inc.", "AVGO" },
                    { 15, "USD", "NYQ", 2.850006, 1.0636733, 273.97199999999998, 269.57999999999998, 272.12, 267.94, 270.79000000000002, 1697486447, "Caterpillar, Inc.", "CAT" },
                    { 16, "USD", "NYQ", 1.3399962999999999, 0.8167721, 165.81, 163.84999999999999, 165.34, 164.06, 165.40000000000001, 1697486447, "Chevron Corporation", "CVX" },
                    { 17, "USD", "NMS", 0.3899994, 0.72531040000000002, 54.585000000000001, 54.040399999999998, 54.07, 53.770000000000003, 54.159999999999997, 1697486447, "Cisco Systems, Inc.", "CSCO" },
                    { 18, "USD", "NYQ", 0.54000090000000001, 1.0209887, 53.560000000000002, 52.840000000000003, 53.020000000000003, 52.890000000000001, 53.43, 1697486447, "Coca-Cola Company (The)", "KO" },
                    { 19, "USD", "NMS", 0.43999863, 1.0043337000000001, 44.325000000000003, 43.765000000000001, 44.049999999999997, 43.810000000000002, 44.25, 1697486447, "Comcast Corporation", "CMCSA" },
                    { 20, "USD", "NMS", 5.3999633999999999, 0.95264329999999997, 574.09659999999997, 568.51999999999998, 569.69000000000005, 566.84000000000003, 572.24000000000001, 1697486447, "Costco Wholesale Corporation", "COST" },
                    { 21, "USD", "NMS", 1.5499954, 1.9961305, 79.444999999999993, 77.659999999999997, 77.739999999999995, 77.650000000000006, 79.200000000000003, 1697486447, "Gilead Sciences, Inc.", "GILD" },
                    { 22, "USD", "NYQ", 5.0900270000000001, 1.6456602, 315.89999999999998, 310.25, 313.18000000000001, 309.30000000000001, 314.38999999999999, 1697486447, "Goldman Sachs Group, Inc. (The)", "GS" },
                    { 23, "USD", "NYQ", 5.4099729999999999, 1.8532382000000001, 298.37, 293.58010000000002, 294.43000000000001, 291.92000000000002, 297.32999999999998, 1697486447, "Home Depot, Inc. (The)", "HD" },
                    { 24, "USD", "NMS", 2.6699982000000002, 1.4545642999999999, 187.5, 185.13, 185.61000000000001, 183.56, 186.22999999999999, 1697486447, "Honeywell International Inc.", "HON" },
                    { 25, "USD", "NMS", 0.59000014999999995, 1.6402562000000001, 36.939999999999998, 36.079999999999998, 36.140000000000001, 35.969999999999999, 36.560000000000002, 1697486447, "Intel Corporation", "INTC" },
                    { 26, "USD", "NYQ", 0.75, 0.54167264999999998, 139.78, 138.52000000000001, 139.28, 138.46000000000001, 139.21000000000001, 1697486447, "International Business Machines", "IBM" },
                    { 27, "USD", "NMS", 7.8500366000000001, 1.4726642000000001, 543.5, 534.47000000000003, 539.84000000000003, 533.04999999999995, 540.89999999999998, 1697486447, "Intuit Inc.", "INTU" },
                    { 28, "USD", "NYQ", 0.67999270000000001, 0.43353049999999999, 158.25, 156.84, 157.81999999999999, 156.84999999999999, 157.53, 1697486447, "Johnson & Johnson", "JNJ" },
                    { 29, "USD", "NYQ", -0.14999390000000001, -0.10134723, 149.52000000000001, 146.72, 149.44999999999999, 148.0, 147.84999999999999, 1697486447, "JP Morgan Chase & Co.", "JPM" },
                    { 30, "USD", "NYQ", 1.6300049000000001, 0.65643949999999995, 250.49000000000001, 248.06999999999999, 249.22, 248.31, 249.94, 1697486447, "McDonald's Corporation", "MCD" },
                    { 31, "USD", "NYQ", 0.12999725000000001, 0.12498534, 105.37, 104.06, 104.2, 104.01000000000001, 104.14, 1697486447, "Merck & Company, Inc.", "MRK" },
                    { 32, "USD", "NMS", 6.4599915000000001, 2.0528111, 321.80000000000001, 315.51999999999998, 318.63999999999999, 314.69, 321.14999999999998, 1697486447, "Meta Platforms, Inc.", "META" },
                    { 33, "USD", "NMS", 4.9100036999999999, 1.4981854999999999, 336.08999999999997, 330.60000000000002, 331.05000000000001, 327.73000000000002, 332.63999999999999, 1697486447, "Microsoft Corporation", "MSFT" },
                    { 34, "USD", "NMS", 1.0900002, 1.7714938, 62.945, 61.829999999999998, 61.869999999999997, 61.530000000000001, 62.619999999999997, 1697486447, "Mondelez International, Inc.", "MDLZ" },
                    { 35, "USD", "NMS", 5.1400145999999998, 1.4451233000000001, 363.07990000000001, 354.76999999999998, 356.20999999999998, 355.68000000000001, 360.81999999999999, 1697486447, "Netflix, Inc.", "NFLX" },
                    { 36, "USD", "NYQ", 2.1299972999999999, 2.1319157999999998, 102.58, 99.599999999999994, 99.719999999999999, 99.909999999999997, 102.04000000000001, 1697486447, "Nike, Inc.", "NKE" },
                    { 37, "USD", "NMS", 6.3400270000000001, 1.3946080000000001, 462.25, 449.12, 450.63, 454.61000000000001, 460.94999999999999, 1697486447, "NVIDIA Corporation", "NVDA" },
                    { 38, "USD", "NMS", 1.0800018, 0.67500114, 161.94999999999999, 159.80000000000001, 161.0, 160.0, 161.08000000000001, 1697486447, "Pepsico, Inc.", "PEP" },
                    { 39, "USD", "NYQ", 1.3800049000000001, 0.95376660000000002, 147.06, 145.46000000000001, 145.86000000000001, 144.69, 146.06999999999999, 1697486447, "Procter & Gamble Company (The)", "PG" },
                    { 40, "USD", "NMS", 1.8499985000000001, 1.7025570000000001, 111.05, 108.95, 109.09, 108.66, 110.51000000000001, 1697486447, "QUALCOMM Incorporated", "QCOM" },
                    { 41, "USD", "NYQ", 3.9400024, 1.9258040999999999, 209.49000000000001, 205.03999999999999, 205.84, 204.59, 208.53, 1697486447, "Salesforce, Inc.", "CRM" },
                    { 42, "USD", "NMS", 2.1699982000000002, 2.3721009999999998, 93.855000000000004, 91.854900000000001, 92.170000000000002, 91.480000000000004, 93.650000000000006, 1697486447, "Starbucks Corporation", "SBUX" },
                    { 43, "USD", "NMS", 2.8000029999999998, 1.1150059999999999, 255.3999, 248.47999999999999, 250.05000000000001, 251.12, 253.91999999999999, 1697486447, "Tesla, Inc.", "TSLA" },
                    { 44, "USD", "NMS", 1.550003, 1.0147318999999999, 154.72499999999999, 153.09999999999999, 153.36000000000001, 152.75, 154.30000000000001, 1697486447, "Texas Instruments Incorporated", "TXN" },
                    { 45, "USD", "NMS", 1.5700073000000001, 1.1082145000000001, 143.66999999999999, 142.06, 142.88, 141.66999999999999, 143.24000000000001, 1697486447, "T-Mobile US, Inc.", "TMUS" },
                    { 46, "USD", "NYQ", -1.3699950999999999, -0.25398500000000002, 546.77999999999997, 536.12, 543.17999999999995, 539.39999999999998, 538.02999999999997, 1697486447, "UnitedHealth Group Incorporated", "UNH" },
                    { 47, "USD", "NYQ", 0.57999990000000001, 1.8910985, 31.32, 30.620000000000001, 30.84, 30.670000000000002, 31.25, 1697486447, "Verizon Communications Inc.", "VZ" },
                    { 48, "USD", "NYQ", 2.4000092, 1.0098073000000001, 240.71000000000001, 238.33000000000001, 239.0, 237.66999999999999, 240.06999999999999, 1697486447, "Visa Inc.", "V" },
                    { 49, "USD", "NYQ", 1.3800049000000001, 0.86342039999999998, 162.08000000000001, 160.31999999999999, 160.53999999999999, 159.83000000000001, 161.21000000000001, 1697486447, "Walmart Inc.", "WMT" },
                    { 50, "USD", "NYQ", 1.3600006, 1.6123304000000001, 85.924999999999997, 84.310000000000002, 84.310000000000002, 84.349999999999994, 85.709999999999994, 1697486447, "Walt Disney Company (The)", "DIS" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.RenameColumn(
                name: "InitialValOrder",
                table: "InitialValueOrders",
                newName: "BookValueOrder");
        }
    }
}
