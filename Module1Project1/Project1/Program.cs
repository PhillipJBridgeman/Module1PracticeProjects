/*
 * FileName: Project1.cs
 * Author: Phillip Bridgeman
 * Date Created: 2023-05-04
 * Last Modified: 2023-05-04
 * Version: 1.0.0
 * Description: Testing the Rectangle.cs class.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle(4, 40);
            Rectangle rectangle2 = new Rectangle(3.5m, 35.9m);

            Console.WriteLine("Test #1:");
            Console.WriteLine(rectangle1.ToString());

            Console.WriteLine("Test #2:");
            Console.WriteLine(rectangle2.ToString());

            Console.Write("Press any key to continue... ");
            Console.ReadKey();
        }
    }
}
