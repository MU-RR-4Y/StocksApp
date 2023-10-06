﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StocksApp.Models;

#nullable disable

namespace StocksApp.Migrations
{
    [DbContext(typeof(StockAppDbContext))]
    partial class StockAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<double?>("bookValue")
                        .HasColumnType("float");

                    b.Property<double?>("currentPerformance")
                        .HasColumnType("float");

                    b.Property<double?>("currentValue")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Portfolio");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            bookValue = 0.0,
                            currentPerformance = 0.0,
                            currentValue = 0.0
                        },
                        new
                        {
                            Id = 2,
                            bookValue = 0.0,
                            currentPerformance = 0.0,
                            currentValue = 0.0
                        },
                        new
                        {
                            Id = 3,
                            bookValue = 0.0,
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

                    b.Property<double>("Change")
                        .HasColumnType("float");

                    b.Property<double>("ChangePercent")
                        .HasColumnType("float");

                    b.Property<double>("Open")
                        .HasColumnType("float");

                    b.Property<int?>("PortfolioId")
                        .HasColumnType("int");

                    b.Property<double>("PreviousClose")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("exchange")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shortName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("symbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PortfolioId");

                    b.ToTable("PortfolioStockModel");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Change = -1.2199936,
                            ChangePercent = -1.3860414000000001,
                            Open = 88.0,
                            PreviousClose = 88.019999999999996,
                            Price = 86.799999999999997,
                            currency = "USD",
                            exchange = "",
                            shortName = "3M Company",
                            symbol = "MMM"
                        },
                        new
                        {
                            Id = 2,
                            Change = -7.3199769999999997,
                            ChangePercent = -1.4119781,
                            Open = 519.84000000000003,
                            PreviousClose = 518.41999999999996,
                            Price = 511.10000000000002,
                            currency = "USD",
                            exchange = "",
                            shortName = "Adobe Inc.",
                            symbol = "ADBE"
                        },
                        new
                        {
                            Id = 3,
                            Change = -2.4049988,
                            ChangePercent = -2.3109434000000002,
                            Open = 103.405,
                            PreviousClose = 104.06999999999999,
                            Price = 101.66500000000001,
                            currency = "USD",
                            exchange = "",
                            shortName = "Advanced Micro Devices, Inc.",
                            symbol = "AMD"
                        },
                        new
                        {
                            Id = 4,
                            Change = -0.94000243999999999,
                            ChangePercent = -0.69506239999999997,
                            Open = 135.06999999999999,
                            PreviousClose = 135.24000000000001,
                            Price = 134.30000000000001,
                            currency = "USD",
                            exchange = "",
                            shortName = "Alphabet Inc.",
                            symbol = "GOOGL"
                        },
                        new
                        {
                            Id = 5,
                            Change = -1.0180054000000001,
                            ChangePercent = -0.7470502,
                            Open = 136.13,
                            PreviousClose = 136.27000000000001,
                            Price = 135.25200000000001,
                            currency = "USD",
                            exchange = "",
                            shortName = "Alphabet Inc.",
                            symbol = "GOOG"
                        },
                        new
                        {
                            Id = 6,
                            Change = -2.3000029999999998,
                            ChangePercent = -1.811026,
                            Open = 126.70999999999999,
                            PreviousClose = 127.0,
                            Price = 124.7,
                            currency = "USD",
                            exchange = "",
                            shortName = "Amazon.com, Inc.",
                            symbol = "AMZN"
                        },
                        new
                        {
                            Id = 7,
                            Change = -0.89480590000000004,
                            ChangePercent = -0.61275489999999999,
                            Open = 145.58000000000001,
                            PreviousClose = 146.03,
                            Price = 145.1352,
                            currency = "USD",
                            exchange = "",
                            shortName = "American Express Company",
                            symbol = "AXP"
                        },
                        new
                        {
                            Id = 8,
                            Change = -0.42999268000000002,
                            ChangePercent = -0.16199242,
                            Open = 266.19,
                            PreviousClose = 265.44,
                            Price = 265.00999999999999,
                            currency = "USD",
                            exchange = "",
                            shortName = "Amgen Inc.",
                            symbol = "AMGN"
                        },
                        new
                        {
                            Id = 9,
                            Change = -0.120010376,
                            ChangePercent = -0.069106520000000005,
                            Open = 173.78999999999999,
                            PreviousClose = 173.66,
                            Price = 173.53999999999999,
                            currency = "USD",
                            exchange = "",
                            shortName = "Apple Inc",
                            symbol = "AAPL"
                        },
                        new
                        {
                            Id = 10,
                            Change = -0.72999570000000003,
                            ChangePercent = -0.52404576999999997,
                            Open = 139.44999999999999,
                            PreviousClose = 139.30000000000001,
                            Price = 138.56999999999999,
                            currency = "USD",
                            exchange = "",
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
