using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.Xml;

namespace StocksApp.Models
{
    public class Holdings
    {
        public int Id { get; set; }
        [Required]
        public int portfolioId { get; set; }
        [Required]
        public string shortName { get; set; }
        [Required]
        public string symbol { get; set; }
        [Required]
        public int numberofShares { get; set; }
        [Required]
        public string currency { get; set; }
        [Required]
        public double currentPrice { get; set; }


        public double averagePrice { get; set; }
        public double bookValue { get; set; } = 0;
        public double currentValue { get; set; } = 0;
        public double currentPerformance { get; set; } = 0;


        public void CalculateShares(Order order)
        {
            if (order.direction == "buy")
            {
                numberofShares += order.numberOfShares;
            } 
            else if (order.direction == "sell")
            {
                numberofShares -= order.numberOfShares;
            }
        }

        public void CalculateHoldingValueVsPerformance(List<Order> orders, double fxRate)
        {
            //Value in GBP
            currentValue = (numberofShares * currentPrice) * fxRate;

            bookValue = CalculateBookValue(orders, fxRate);

            //Average USD price to compare against current visible USD price of stock
            averagePrice = (bookValue / numberofShares) / fxRate;

            if(bookValue == 0 || currentValue == 0)
            {
                currentPerformance = 0;
            }
            else
            {
                currentPerformance = (currentValue / bookValue) - 1;
            }

        }

        public double CalculateBookValue(List<Order> orders, double fxRate)
        {
            double orderTotal = 0;

            //Set a list for BUY orders
            List<Order> FIFOOrders = new List<Order>();
            // Set A list for SELL orders
            List<Order> SellOrders = new List<Order>();
            // Set a list for Buy Order holdings which have ben sold
            List<Order> SoldOrders = new List<Order>();

            
            List<Order> FIFOOrdersCopy = new List<Order> ();



            foreach (var order in orders)
            {
                // ADD BUY orders to a List
                if (order.symbol == symbol  && (order.direction == "buy" || order.direction == "Buy"))
                {   // total cash value in GBP
                        FIFOOrders.Add(order);
                        
                }
                // ADD sell orders to a list
                else if(order.symbol == symbol && (order.direction == "sell" || order.direction == "Sell"))
                {
                    SellOrders.Add(order);
                }
            }
            foreach (var order in FIFOOrders)
            {
                FIFOOrdersCopy.Add(order);
            }


            foreach (var order in SellOrders)
            {
                int BuyOrderTotal = 0;
                int difference = 0;


                
                while (order.numberOfShares >= BuyOrderTotal) 
                {
                    Order buyOrder = FIFOOrdersCopy[0];
                    FIFOOrdersCopy.RemoveAt(0);
                    SoldOrders.Add(buyOrder); 
                    BuyOrderTotal += buyOrder.numberOfShares;
                }

                difference = BuyOrderTotal - order.numberOfShares;

                for (int i = 0; i < SoldOrders.Count()-2; i++)
                {
                    FIFOOrders.RemoveAt(i);
                    
                }
                // remaining order in SoldOrders has only been partially sold.
                FIFOOrders[0].numberOfShares = difference;
            }
            

            //Remaing orders in FIFOOrders are the Buy order which have not yet been sold.

            foreach (var order in FIFOOrders)
            {
                orderTotal += order.gbpCashValue;
            }


            return orderTotal;
        }
    }
}
