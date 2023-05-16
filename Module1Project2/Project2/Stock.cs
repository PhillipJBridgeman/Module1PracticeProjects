/*
 * FileName: Stock.cs
 * Author: Phillip Bridgeman
 * Date Created: 2023-05-04
 * Last Data Modified: 2023-05-04
 * Version: 1.0.0
 * Description:
 * Copyright:
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    /// <summary>
    /// Represents a Stock
    /// </summary>
    public class Stock
    {
        private string symbol;
        private string name;
        private decimal previousClosingPrice;
        private decimal currentPrice;

        /// <summary>
        /// Initializes an instance of the Stock class with specified name, symbol, and previous closing price of the stock.
        /// </summary>
        /// <param name="symbol">The symbol for the Stock.</param>
        /// <param name="name">The name for the Stock.</param>
        /// <param name="currentPrice">The current price of the Stock.</param>
        public Stock(string symbol, string name, decimal currentPrice)
        {
            this.symbol = symbol;
            this.name = name;
            this.previousClosingPrice = currentPrice;
            this.currentPrice = currentPrice;
        }

        /// <summary>
        /// Gets the current price of the Stock.
        /// </summary>
        /// <returns>Returns the decimal value for the current stock price.</returns>
        public decimal GetCurrentPrice()
        {
            return this.currentPrice;
        }

        /// <summary>
        /// Sets the previous closing price to the current price, then updates the new current price to the new current stock price.
        /// </summary>
        /// <param name="currentPrice">Sets the new current stock price.</param>
        public void SetCurrentPrice(decimal currentPrice)
        {
            this.previousClosingPrice = this.currentPrice;
            this.currentPrice = currentPrice;
        }

        /// <summary>
        /// Gets the calculated percent change of the stock price.
        /// </summary>
        /// <returns>Returns the percent change of the stock.</returns>
        public decimal GetChangePercent()
        {
            decimal percentChange = ((this.currentPrice - this.previousClosingPrice) / this.previousClosingPrice);

            if (percentChange < 0)
            {
                percentChange = Math.Abs(percentChange);
            }

            return percentChange * 100;
        }
    }
}
