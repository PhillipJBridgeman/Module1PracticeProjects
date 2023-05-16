/*
 * FileName: Program.cs
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
    public class Program
    {
        static void Main(string[] args)
        {
            Stock stock1 = new Stock("ORCL", "Oracle Corporation", 34.5m);
            Console.WriteLine($"Original Stock Current Price: {stock1.GetCurrentPrice():C}");

            stock1.SetCurrentPrice(34.35m);
            Console.WriteLine($"New Stock Current Price: {stock1.GetCurrentPrice():C}");
            Console.WriteLine($"Price Change Percentage: {stock1.GetChangePercent():F2}%");

            Console.Write("Press any key to continue... ");
            Console.ReadKey();
        }
    }
}
