﻿using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using MudBlazor;
using StocksApp.Pages.Users;
using System.ComponentModel.DataAnnotations;

namespace StocksApp.Models
{
    public class Portfolio
    {
        
        public int Id {  get; set; }
        [Required]
        public List<Holdings> holdings { get; set; } = new List<Holdings>();
        [Required]
        public List<Order> orders { get; set; } = new List<Order>();
        [Required]
        public List<InitialValueOrder> initialValueOrders { get; set; } = new List<InitialValueOrder>();
        public double initialValue { get; set; } = 0;
        public double currentValue { get; set; } = 0;
        public double currentPerformance { get; set; } = 0;
        public double cash { get; set; } = 0;


        public void CreditCash(double amount)
        {
            cash += amount;
        }

        public void DebitCash(double amount)
        {
            cash -= amount;
        }



        // Create a new order on portfolio. Save to DB
        public Order CreateNewOrder(Stock stock, string _direction, int _numberOfShares, double fxRate)
        {
            Order order = new Order
            {
                shortName = stock.shortName,
                direction = _direction,
                numberOfShares = _numberOfShares,
                symbol = stock.symbol,
                currency = stock.currency,
                price = stock.regularMarketPrice,
                fxRate = fxRate,
                portfolioId = Id,
                gbpCashValue = (_numberOfShares * stock.regularMarketPrice) * fxRate
            };

            InitialValueOrder bvOrder = new InitialValueOrder
            {
                shortName = stock.shortName,
                direction = _direction,
                numberOfShares = _numberOfShares,
                symbol = stock.symbol,
                currency = stock.currency,
                price = stock.regularMarketPrice,
                fxRate = fxRate,
                portfolioId = Id,
                gbpCashValue = (_numberOfShares * stock.regularMarketPrice) * fxRate
            };

            //DEBIT or CREDIT cash appropiately
            if(_direction == "buy" || _direction == "Buy")
            {
                cash -= order.gbpCashValue;
            }
            else
            {
                cash += order.gbpCashValue;
            }
            
            orders.Add(order);
            initialValueOrders.Add(bvOrder);
            return order;
        }

        public Holdings FindHolding(string symbol)
        {
            foreach (var holding in holdings)
            {
                if (holding.symbol == symbol) 
                {
                    return holding;
                }
            }
            return null;
        }

        public void UpdateHoldings(Order _order)
        {
                var orderStock = _order.symbol;
                //check if stock already has a holding
                var holding = FindHolding(orderStock);
                if (holding != null) { holding.numberofShares = 0; }

             //loop through each order on portfolio
            foreach (Order order in orders)
            {
                if (order.symbol == orderStock && order.portfolioId == Id)
                {

                    // update existing holdings in DB
                    Holdings updatedHolding = holding;
                    if (updatedHolding is not null)
                    {
                        //int index = holdings.IndexOf(updatedHolding);
                        if(order.direction == "buy" || order.direction == "Buy" )
                        {
                            holdings.FirstOrDefault(h =>h.Id == updatedHolding.Id).numberofShares += order.numberOfShares;
                            //holdings[index].CalculateHoldingValueVsPerformance(orders, fxRate);
                        }
                        else
                        {
                            holdings.FirstOrDefault(h => h.Id == updatedHolding.Id).numberofShares -= order.numberOfShares;
                            //holdings[index].CalculateHoldingValueVsPerformance(orders, fxRate);
                        };
                    }
                    else
                    {
                        // Add new holding in DB if required
                        Holdings newHolding = new Holdings()
                        {
                            portfolioId = Id,
                            shortName = order.shortName,
                            symbol = order.symbol,
                            numberofShares = order.numberOfShares,
                            currency = order.currency,
                            currentPrice = order.price
                        };
                        //newPSM.CalculateHoldingValueVsPerformance(orders, fxRate);
                        holdings.Add(newHolding);
                    }
                }

            }

        }

        public void CalculatePortfolioValueVsPerformance(double fxRate)
        {
            foreach (Holdings holding in holdings)
            {
                //Values in GBP
                initialValue += holding.initialValue * fxRate;
                currentValue += holding.currentValue * fxRate;
            }
            if (initialValue == 0 || currentValue == 0)
            {
                currentPerformance = 0;
            }
            else
            {
                currentPerformance = (currentValue / initialValue) - 1;
            }


        }

    }
}
