﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StocksApp.Models;

#nullable disable

namespace StocksApp.Migrations
{
    [DbContext(typeof(StockAppDbContext))]
    [Migration("20231010121055_amendedPortfolioStockModel_addedOrderModel")]
    partial class amendedPortfolioStockModel_addedOrderModel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StocksApp.Models.Portfolio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("bookValue")
                        .HasColumnType("float");

                    b.Property<double>("cash")
                        .HasColumnType("float");

                    b.Property<double>("currentPerformance")
                        .HasColumnType("float");

                    b.Property<double>("currentValue")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Portfolio");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            bookValue = 0.0,
                            cash = 50000.0,
                            currentPerformance = 0.0,
                            currentValue = 0.0
                        },
                        new
                        {
                            Id = 2,
                            bookValue = 0.0,
                            cash = 76000.0,
                            currentPerformance = 0.0,
                            currentValue = 0.0
                        },
                        new
                        {
                            Id = 3,
                            bookValue = 0.0,
                            cash = 25000.0,
                            currentPerformance = 0.0,
                            currentValue = 0.0
                        });
                });

            modelBuilder.Entity("StocksApp.Models.PortfolioStockModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("PortfolioId")
                        .HasColumnType("int");

                    b.Property<double>("averagePrice")
                        .HasColumnType("float");

                    b.Property<double>("bookValue")
                        .HasColumnType("float");

                    b.Property<string>("currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("currentPerformance")
                        .HasColumnType("float");

                    b.Property<double>("currentValue")
                        .HasColumnType("float");

                    b.Property<int>("numberofShares")
                        .HasColumnType("int");

                    b.Property<string>("shortName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("symbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PortfolioId");

                    b.ToTable("PortfolioStockModel");
                });

            modelBuilder.Entity("StocksApp.Models.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("exchange")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("regularMarketChange")
                        .HasColumnType("float");

                    b.Property<double>("regularMarketChangePercent")
                        .HasColumnType("float");

                    b.Property<double>("regularMarketDayHigh")
                        .HasColumnType("float");

                    b.Property<double>("regularMarketDayLow")
                        .HasColumnType("float");

                    b.Property<double>("regularMarketOpen")
                        .HasColumnType("float");

                    b.Property<double>("regularMarketPreviousClose")
                        .HasColumnType("float");

                    b.Property<double>("regularMarketPrice")
                        .HasColumnType("float");

                    b.Property<int>("regularMarketTime")
                        .HasColumnType("int");

                    b.Property<string>("shortName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("symbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stocks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            currency = "USD",
                            exchange = "NYQ",
                            regularMarketChange = -1.2199936,
                            regularMarketChangePercent = -1.3860414000000001,
                            regularMarketDayHigh = 0.0,
                            regularMarketDayLow = 0.0,
                            regularMarketOpen = 88.0,
                            regularMarketPreviousClose = 88.019999999999996,
                            regularMarketPrice = 86.799999999999997,
                            regularMarketTime = 0,
                            shortName = "3M Company",
                            symbol = "MMM"
                        },
                        new
                        {
                            Id = 2,
                            currency = "USD",
                            exchange = "NMS",
                            regularMarketChange = -7.3199769999999997,
                            regularMarketChangePercent = -1.4119781,
                            regularMarketDayHigh = 0.0,
                            regularMarketDayLow = 0.0,
                            regularMarketOpen = 519.84000000000003,
                            regularMarketPreviousClose = 518.41999999999996,
                            regularMarketPrice = 511.10000000000002,
                            regularMarketTime = 0,
                            shortName = "Adobe Inc.",
                            symbol = "ADBE"
                        },
                        new
                        {
                            Id = 3,
                            currency = "USD",
                            exchange = "NMS",
                            regularMarketChange = -2.4049988,
                            regularMarketChangePercent = -2.3109434000000002,
                            regularMarketDayHigh = 0.0,
                            regularMarketDayLow = 0.0,
                            regularMarketOpen = 103.405,
                            regularMarketPreviousClose = 104.06999999999999,
                            regularMarketPrice = 101.66500000000001,
                            regularMarketTime = 0,
                            shortName = "Advanced Micro Devices, Inc.",
                            symbol = "AMD"
                        },
                        new
                        {
                            Id = 4,
                            currency = "USD",
                            exchange = "NMS",
                            regularMarketChange = -0.94000243999999999,
                            regularMarketChangePercent = -0.69506239999999997,
                            regularMarketDayHigh = 0.0,
                            regularMarketDayLow = 0.0,
                            regularMarketOpen = 135.06999999999999,
                            regularMarketPreviousClose = 135.24000000000001,
                            regularMarketPrice = 134.30000000000001,
                            regularMarketTime = 0,
                            shortName = "Alphabet Inc.",
                            symbol = "GOOGL"
                        },
                        new
                        {
                            Id = 5,
                            currency = "USD",
                            exchange = "NMS",
                            regularMarketChange = -1.0180054000000001,
                            regularMarketChangePercent = -0.7470502,
                            regularMarketDayHigh = 0.0,
                            regularMarketDayLow = 0.0,
                            regularMarketOpen = 136.13,
                            regularMarketPreviousClose = 136.27000000000001,
                            regularMarketPrice = 135.25200000000001,
                            regularMarketTime = 0,
                            shortName = "Alphabet Inc.",
                            symbol = "GOOG"
                        },
                        new
                        {
                            Id = 6,
                            currency = "USD",
                            exchange = "NMS",
                            regularMarketChange = -2.3000029999999998,
                            regularMarketChangePercent = -1.811026,
                            regularMarketDayHigh = 0.0,
                            regularMarketDayLow = 0.0,
                            regularMarketOpen = 126.70999999999999,
                            regularMarketPreviousClose = 127.0,
                            regularMarketPrice = 124.7,
                            regularMarketTime = 0,
                            shortName = "Amazon.com, Inc.",
                            symbol = "AMZN"
                        },
                        new
                        {
                            Id = 7,
                            currency = "USD",
                            exchange = "NYQ",
                            regularMarketChange = -0.89480590000000004,
                            regularMarketChangePercent = -0.61275489999999999,
                            regularMarketDayHigh = 0.0,
                            regularMarketDayLow = 0.0,
                            regularMarketOpen = 145.58000000000001,
                            regularMarketPreviousClose = 146.03,
                            regularMarketPrice = 145.1352,
                            regularMarketTime = 0,
                            shortName = "American Express Company",
                            symbol = "AXP"
                        },
                        new
                        {
                            Id = 8,
                            currency = "USD",
                            exchange = "NMS",
                            regularMarketChange = -0.42999268000000002,
                            regularMarketChangePercent = -0.16199242,
                            regularMarketDayHigh = 0.0,
                            regularMarketDayLow = 0.0,
                            regularMarketOpen = 266.19,
                            regularMarketPreviousClose = 265.44,
                            regularMarketPrice = 265.00999999999999,
                            regularMarketTime = 0,
                            shortName = "Amgen Inc.",
                            symbol = "AMGN"
                        },
                        new
                        {
                            Id = 9,
                            currency = "USD",
                            exchange = "NMS",
                            regularMarketChange = -0.120010376,
                            regularMarketChangePercent = -0.069106520000000005,
                            regularMarketDayHigh = 0.0,
                            regularMarketDayLow = 0.0,
                            regularMarketOpen = 173.78999999999999,
                            regularMarketPreviousClose = 173.66,
                            regularMarketPrice = 173.53999999999999,
                            regularMarketTime = 0,
                            shortName = "Apple Inc",
                            symbol = "AAPL"
                        },
                        new
                        {
                            Id = 10,
                            currency = "USD",
                            exchange = "NMS",
                            regularMarketChange = -0.72999570000000003,
                            regularMarketChangePercent = -0.52404576999999997,
                            regularMarketDayHigh = 0.0,
                            regularMarketDayLow = 0.0,
                            regularMarketOpen = 139.44999999999999,
                            regularMarketPreviousClose = 139.30000000000001,
                            regularMarketPrice = 138.56999999999999,
                            regularMarketTime = 0,
                            shortName = "Applied Materials, Inc.",
                            symbol = "AMAT"
                        });
                });

            modelBuilder.Entity("StocksApp.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PortfolioId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PortfolioId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Admin",
                            LastName = "Test",
                            PortfolioId = 1
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Test",
                            LastName = "User",
                            PortfolioId = 2
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "User",
                            LastName = "Admin",
                            PortfolioId = 3
                        });
                });

            modelBuilder.Entity("StocksApp.Models.PortfolioStockModel", b =>
                {
                    b.HasOne("StocksApp.Models.Portfolio", null)
                        .WithMany("holdings")
                        .HasForeignKey("PortfolioId");
                });

            modelBuilder.Entity("StocksApp.Models.User", b =>
                {
                    b.HasOne("StocksApp.Models.Portfolio", "userPortfolio")
                        .WithMany()
                        .HasForeignKey("PortfolioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("userPortfolio");
                });

            modelBuilder.Entity("StocksApp.Models.Portfolio", b =>
                {
                    b.Navigation("holdings");
                });
#pragma warning restore 612, 618
        }
    }
}
